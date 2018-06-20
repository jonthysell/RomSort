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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                _rootDir = value.Trim();
                View.Update(UpdateType.RootDirectory);

                SourceTree = LoadDirectory(_rootDir);
                DestinationTree = SourceTree; // TODO
            }
        }
        private string _rootDir;

        public DirectoryNode SourceTree
        {
            get
            {
                return _sourceTree;
            }
            private set
            {
                _sourceTree = value;
                View.Update(UpdateType.SourceTree);
            }
        }
        private DirectoryNode _sourceTree;

        public DirectoryNode DestinationTree
        {
            get
            {
                return _destinationTree;
            }
            private set
            {
                _destinationTree = value;
                View.Update(UpdateType.DestinationTree);
            }
        }
        private DirectoryNode _destinationTree;

        public RomSortApp(IRomSortAppView view)
        {
            View = view ?? throw new ArgumentNullException(nameof(view));
        }

        public void Open()
        {
            string rootDir;
            if (View.TryPromptForDirectory(Resources.RootDirectoryPrompt, out rootDir))
            {
                RootDir = rootDir;
            }
        }

        public void Sort()
        {
            if (string.IsNullOrEmpty(RootDir))
            {
                throw new ArgumentNullException(nameof(RootDir), "Select a folder first");
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
    }
}
