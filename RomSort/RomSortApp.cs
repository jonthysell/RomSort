// 
// RomSortApp.cs
//  
// Author:
//       Jon Thysell <thysell@gmail.com>
// 
// Copyright (c) 2018, 2019 Jon Thysell <http://jonthysell.com>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;

using RomSort.Properties;

namespace RomSort
{
    public class RomSortApp
    {
        public IRomSortAppView View { get; private set; }

        public string RootDir
        {
            get
            {
                return _rootDir;
            }
            private set
            {
                value = value?.Trim();
                if (Directory.Exists(value))
                {
                    _rootDir = Path.GetFullPath(value);
                }
                else if (File.Exists(value))
                {
                    _rootDir = Path.GetDirectoryName(value);
                }
                else
                {
                    throw new DirectoryNotFoundException(string.Format(Resources.DirectoryNotFoundExceptionMessageFormat, value));
                }

                View.Update(UpdateType.RootDirectory);
            }
        }
        private string _rootDir = "";

        public DirectoryNode SourceTree
        {
            get
            {
                return _sourceTree;
            }
            private set
            {
                _sourceTree = value;
                FlagConflicts();
                SourceTreeMetrics = NodeMetrics.GetMetrics(_sourceTree);
                View.Update(UpdateType.SourceTree);
                UpdateDestinationTree();
            }
        }
        private DirectoryNode _sourceTree = null;

        public NodeMetrics SourceTreeMetrics { get; private set; }

        public DirectoryNode DestinationTree
        {
            get
            {
                return _destinationTree;
            }
            private set
            {
                _destinationTree = value;
                DestinationTreeMetrics = NodeMetrics.GetMetrics(_destinationTree);
                View.Update(UpdateType.DestinationTree);
            }
        }
        private DirectoryNode _destinationTree = null;

        public NodeMetrics DestinationTreeMetrics { get; private set; }

        public uint MaxDirectories { get; set; } = 27;

        public bool HasConflicts
        {
            get
            {
                return ConflictCount > 0;
            }
        }

        public int ConflictCount { get; private set; } = 0;

        public bool SourceProcessed
        {
            get
            {
                return null != SourceTree;
            }
        }

        public bool CanSort
        {
            get
            {
                return null != SourceTree && null != DestinationTree && !HasConflicts;
            }
        }

        private Dictionary<FileNode, FileNode> _sourceToDestinationMap = new Dictionary<FileNode, FileNode>();

        public RomSortApp(IRomSortAppView view)
        {
            View = view ?? throw new ArgumentNullException(nameof(view));
        }

        public bool Open()
        {
            string rootDir;
            if (View.TryPromptForDirectory(Resources.RootDirectoryPrompt, out rootDir, RootDir))
            {
                RootDir = rootDir;
                return true;
            }

            return false;
        }

        public void Load()
        {
            try
            {
                SourceTree = LoadDirectory(RootDir);
            }
            catch (Exception)
            {
                RootDir = "";
                SourceTree = null;
                throw;
            }
        }

        public void TryLoad(string path)
        {
            RootDir = path;
            Load();
        }

        public void UpdateDestinationTree()
        {
            _sourceToDestinationMap.Clear();

            if (null == SourceTree || HasConflicts)
            {
                DestinationTree = null;
            }
            else
            {
                Dictionary<string, FileNode> sourceFileNameMap = FileNameMap(SourceTree);

                List<string> fileNames = new List<string>();
                foreach (string name in sourceFileNameMap.Keys)
                {
                    ListUtils.SortedInsert(fileNames, name);
                }

                AlphaFolderCollection alphaFolders = MaxDirectories > 0 ? AlphaFolderCollection.GetAlphaFolders(fileNames, MaxDirectories) : null;

                DirectoryNode destinationTree = new DirectoryNode(SourceTree.Name);

                foreach (string fileName in fileNames)
                {
                    string folderName = alphaFolders?.GetFolderNameForFile(fileName);

                    DirectoryNode destinationDir = null != folderName ? destinationTree.FindDirectory(folderName) : destinationTree;
                    if (null == destinationDir)
                    {
                        destinationDir = (DirectoryNode)destinationTree.AddChildNode(new DirectoryNode(folderName, destinationTree));
                    }

                    FileNode destinationFile = (FileNode)destinationDir.AddChildNode(new FileNode(fileName, destinationDir));

                    _sourceToDestinationMap.Add(sourceFileNameMap[fileName], destinationFile);
                }

                DestinationTree = destinationTree;
            }
        }

        public void Sort()
        {
            if (string.IsNullOrEmpty(RootDir) || null == SourceTree)
            {
                throw new Exception();
            }

            if (HasConflicts)
            {
                throw new Exception(Resources.NoSourceDirectoryExceptionMessage);
            }

            if (View.PromptForConfirmation(Resources.ExecuteSortConfirmPrompt))
            {
                if (!ValidateDiskMatchesDirectoryNode(SourceTree))
                {
                    throw new Exception(Resources.SourceDiskValidationExceptionMessage);
                }

                // Move files
                foreach (KeyValuePair<FileNode, FileNode> kvp in _sourceToDestinationMap)
                {
                    string sourcePath = kvp.Key.FullPath;
                    string destPath = kvp.Value.FullPath;

                    string destDir = Path.GetDirectoryName(destPath);
                    if (!Directory.Exists(destDir))
                    {
                        Directory.CreateDirectory(destDir);
                    }

                    File.Move(sourcePath, destPath);
                }

                // Clear empty directories
                DeleteEmptyDirectories(DestinationTree.FullPath);

                if (!ValidateDiskMatchesDirectoryNode(DestinationTree))
                {
                    throw new Exception(Resources.DestinationDiskValidationExceptionMessage);
                }
            }
        }

        public void Exit()
        {
            View.Exit();
        }

        private DirectoryNode LoadDirectory(string name, DirectoryNode parent = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }

            DirectoryNode node = new DirectoryNode(name, parent);

            foreach (string filePath in Directory.GetFiles(node.FullPath, "*", SearchOption.TopDirectoryOnly))
            {
                node.AddChildNode(new FileNode(Path.GetFileName(filePath), node));
            }

            foreach (string dirPath in Directory.GetDirectories(node.FullPath, "*", SearchOption.TopDirectoryOnly))
            {
                DirectoryNode subDirNode = LoadDirectory(Path.GetFileName(dirPath), node);
                node.AddChildNode(subDirNode);
            }

            return node;
        }

        private void FlagConflicts()
        {
            ConflictCount = 0;

            Dictionary<string, List<FileNode>> filesByName = new Dictionary<string, List<FileNode>>();

            SourceTree?.ForEachChildNode((child) =>
            {
                if (child is FileNode fn)
                {
                    string key = fn.Name.ToLower();
                    if (!filesByName.ContainsKey(key))
                    {
                        filesByName[key] = new List<FileNode>();
                    }

                    filesByName[key].Add(fn);
                }
            });

            foreach (KeyValuePair<string, List<FileNode>> kvp in filesByName)
            {
                if (kvp.Value.Count > 1)
                {
                    foreach (FileNode fn in kvp.Value)
                    {
                        fn.IsConflict = true;
                        ConflictCount++;

                        // Update parents
                        DirectoryNode parent = fn.Parent;
                        while (null != parent)
                        {
                            parent.IsConflict = true;
                            parent = parent.Parent;
                        }
                    }
                }
            }
        }

        private bool ValidateDiskMatchesDirectoryNode(DirectoryNode directoryNode)
        {
            if (!Directory.Exists(directoryNode.FullPath))
            {
                return false;
            }

            int fileNodeCount = 0;
            int dirNodeCount = 0;

            foreach (NodeBase node in directoryNode.Children)
            {
                if (node is FileNode fn)
                {
                    if (!ValidateDiskMatchesFileNode(fn))
                    {
                        return false;
                    }

                    fileNodeCount++;
                }
                else if (node is DirectoryNode dn)
                {
                    if (!ValidateDiskMatchesDirectoryNode(dn))
                    {
                        return false;
                    }

                    dirNodeCount++;
                }
            }

            int fileCount = Directory.GetFiles(directoryNode.FullPath, "*", SearchOption.TopDirectoryOnly).Length;
            int dirCount = Directory.GetDirectories(directoryNode.FullPath, "*", SearchOption.TopDirectoryOnly).Length;

            return fileNodeCount == fileCount && dirNodeCount == dirCount;
        }

        private bool ValidateDiskMatchesFileNode(FileNode fileNode)
        {
            return File.Exists(fileNode.FullPath);
        }

        private Dictionary<string, FileNode> FileNameMap(DirectoryNode rootNode)
        {
            Dictionary<string, FileNode> filenames = new Dictionary<string, FileNode>();

            rootNode.ForEachChildNode((child) =>
            {
                if (child is FileNode fn)
                {
                    filenames.Add(fn.Name, fn);
                }
            });

            return filenames;
        }

        private void DeleteEmptyDirectories(string path)
        {
            foreach (string dirPath in Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly))
            {
                DeleteEmptyDirectories(dirPath);
            }

            int numFiles = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;
            int numDirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).Length;

            if (numFiles == 0 && numDirs == 0)
            {
                Directory.Delete(path);
            }            
        }
    }
}
