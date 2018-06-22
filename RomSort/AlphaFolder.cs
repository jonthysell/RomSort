// 
// AlphaFolder.cs
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
    public class AlphaFolder : IComparable
    {
        public string Start { get; private set; }
        public string End { get; private set; }

        public List<string> Files { get; private set; }

        public AlphaFolder(string start, string end = null)
        {
            if (null == start || "" == start.Trim())
            {
                throw new ArgumentNullException(nameof(start));
            }

            Start = start.Trim();
            End = (null == end || "" == end.Trim()) ? Start : end.Trim();

            if (string.Compare(Start, End, true) > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(end));
            }

            Files = new List<string>();
        }

        public bool DoesAccept(string fileName)
        {
            if (null == fileName || "" == fileName.Trim())
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            fileName = fileName.Trim().ToUpper();

            if (Start == NumericAlphaFolder && !char.IsLetter(fileName[0]))
            {
                return true;
            }
            else if (char.IsLetter(fileName[0]))
            {
                if (Start == End)
                {
                    return fileName.StartsWith(Start, StringComparison.CurrentCultureIgnoreCase);
                }
                else
                {
                    bool gteStart = string.Compare(fileName, Start, true) >= 0;
                    bool lteEnd = string.Compare(fileName.Substring(0, Math.Min(fileName.Length, End.Length)), End, true) <= 0;
                    return gteStart && lteEnd;
                }
            }

            return false;
        }

        public static AlphaFolder Combine(AlphaFolder folderA, AlphaFolder folderB)
        {
            if (null == folderA)
            {
                throw new ArgumentNullException(nameof(folderA));
            }

            if (null == folderB)
            {
                throw new ArgumentNullException(nameof(folderB));
            }

            if (folderA == folderB)
            {
                throw new ArgumentException();
            }

            AlphaFolder combined = null;

            if (string.Compare(folderA.Start, folderB.Start, true) <= 0)
            {
                // A has the lowest Start
                if (string.Compare(folderA.End, folderB.End, true) <= 0)
                {
                    // B has the highest End
                    combined = new AlphaFolder(folderA.Start, folderB.End);
                }
                else
                {
                    // A has the highest End
                    combined = new AlphaFolder(folderA.Start, folderA.End);
                }
            }
            else
            {
                // B has the lower Start
                if (string.Compare(folderB.End, folderA.End, true) <= 0)
                {
                    // A has the highest End
                    combined = new AlphaFolder(folderB.Start, folderA.End);
                }
                else
                {
                    // B has the highest End
                    combined = new AlphaFolder(folderB.Start, folderB.End);
                }
            }

            foreach (string fileName in folderA.Files)
            {
                ListUtils.SortedInsert(combined.Files, fileName);
            }

            foreach (string fileName in folderB.Files)
            {
                ListUtils.SortedInsert(combined.Files, fileName);
            }

            return combined;
        }

        public override string ToString()
        {
            if (Start == End)
            {
                return Start;
            }

            return string.Format("{0}-{1}", Start, End);
        }

        public int CompareTo(object obj)
        {
            AlphaFolder other = obj as AlphaFolder;

            if (null == other)
            {
                throw new ArgumentException();
            }

            if (this == other)
            {
                throw new ArgumentException("AlphaFolders overlap!");
            }

            int startCmp = string.Compare(Start, other.Start, true);
            int endCmp = string.Compare(End, other.End, true);

            if (startCmp < 0 && endCmp < 0)
            {
                return -1;
            }
            else if (startCmp > 0 && endCmp > 0)
            {
                return 1;
            }

            throw new ArgumentException("AlphaFolders overlap!");
        }

        public static readonly string NumericAlphaFolder = "0";
    }
}
