// 
// NodeBase.cs
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

namespace RomSort
{
    public abstract class NodeBase : IComparable
    {
        public NodeBase Parent { get; protected set; } = null;

        public string Name { get; protected set; } = "";

        public string FullPath
        {
            get
            {
                string path = Name;

                if (null != Parent)
                {
                    path = Path.Combine(Parent.FullPath, path);
                }

                return path;
            }
        }

        public bool IsRoot
        {
            get
            {
                return null == Parent;
            }
        }

        public IEnumerable<NodeBase> Children
        {
            get
            {
                return _children;
            }
        }
        protected List<NodeBase> _children = null;

        protected NodeBase(string name)
        {
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentNullException(nameof(name)) : name;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is NodeBase))
            {
                throw new ArgumentException();
            }

            if (this is DirectoryNode && obj is FileNode)
            {
                return -1;
            }
            else if (this is FileNode && obj is DirectoryNode)
            {
                return 1;
            }

            return Name.CompareTo((obj as NodeBase).Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class DirectoryNode : NodeBase
    {
        public DirectoryNode(string name, DirectoryNode parent = null) : base(name)
        {
            Parent = parent;
            _children = new List<NodeBase>();
        }

        public NodeBase AddChildNode(NodeBase child)
        {
            if (null == child)
            {
                throw new ArgumentNullException(nameof(child));
            }

            if (child.Parent != this)
            {
                throw new ArgumentException();
            }

            if (ListUtils.SortedInsert(_children, child))
            {
                return child;
            }

            return null;
        }
    }

    public class FileNode : NodeBase
    {
        public bool IsConflict { get; set; } = false;

        public FileNode(string name, DirectoryNode parent) : base(name)
        {
            Parent = parent ?? throw new ArgumentNullException(nameof(parent));
        }
    }
}
