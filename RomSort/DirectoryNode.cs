// 
// DirectoryNode.cs
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

namespace RomSort
{
    public class DirectoryNode : NodeBase
    {
        public IEnumerable<NodeBase> Children
        {
            get
            {
                return _children;
            }
        }
        protected List<NodeBase> _children = new List<NodeBase>();

        public DirectoryNode(string name, DirectoryNode parent = null) : base(name)
        {
            Parent = parent;
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

        public void ForEachChildNode(Action<NodeBase> action)
        {
            ForEachChildNode(action, this);
        }

        private void ForEachChildNode(Action<NodeBase> action, DirectoryNode currentDirectory)
        {
            foreach (NodeBase child in currentDirectory.Children)
            {
                if (child is DirectoryNode)
                {
                    ForEachChildNode(action, child as DirectoryNode);
                }
                action(child);
            }
        }
    }
}
