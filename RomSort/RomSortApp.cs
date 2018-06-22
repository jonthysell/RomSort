// 
// RomSortApp.cs
//  
// Author:
//       Jon Thysell <thysell@gmail.com>
// 
// Copyright (c) 2018 Jon Thysell <http://jonthysell.com>
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
            set
            {
                _rootDir = string.IsNullOrEmpty(value) ? "" : Path.GetFullPath(value);
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
                SourceTreeMetrics = NodeMetrics.GetMetrics(_sourceTree);
                View.Update(UpdateType.SourceTree);
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

        public bool HasConflicts { get; set; } = false;

        public bool CanSort
        {
            get
            {
                return null != SourceTree && null != DestinationTree && !HasConflicts;
            }
        }

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
            DirectoryNode sourceTree = LoadDirectory(RootDir);

            int conflictCount = FlagConflicts(sourceTree);

            HasConflicts = conflictCount > 0;

            SourceTree = sourceTree;

            UpdateDestinationTree();
        }

        private void UpdateDestinationTree()
        {
            if (HasConflicts)
            {
                DestinationTree = null;
            }
            else
            {

            }
        }

        public void Sort()
        {
            if (null == SourceTree)
            {
                throw new Exception("Load a valid root directory first.");
            }

            if (HasConflicts)
            {
                throw new Exception("There are file conflicts that must be resolved.");
            }

            if (View.PromptForConfirmation(Resources.ExecuteSortConfirmPrompt))
            {

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

        private int FlagConflicts(DirectoryNode rootNode)
        {
            int conflictCount = 0;

            Dictionary<string, List<FileNode>> filesByName = new Dictionary<string, List<FileNode>>();

            rootNode.ForEachChildNode((child) =>
            {
                FileNode fn = child as FileNode;
                if (null != fn)
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
                        conflictCount++;
                    }
                }
            }

            return conflictCount;
        }
    }
}
