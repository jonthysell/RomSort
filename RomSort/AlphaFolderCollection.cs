// 
// AlphaFolderCollection.cs
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

namespace RomSort
{
    public class AlphaFolderCollection
    {
        public uint Count
        {
            get
            {
                return (uint)_folders.Count;
            }
        }

        private List<AlphaFolder> _folders;

        public AlphaFolderCollection()
        {
            _folders = new List<AlphaFolder>();
        }

        public bool HasFolderForFile(string fileName)
        {
            return null != GetFolderForFile(fileName);
        }

        public string GetFolderNameForFile(string fileName)
        {
            AlphaFolder folder = GetFolderForFile(fileName);
            return folder.ToString();
        }

        private AlphaFolder GetFolderForFile(string fileName)
        {
            if (null == fileName || "" == fileName.Trim())
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            fileName = fileName.Trim();

            foreach (AlphaFolder folder in _folders)
            {
                if (folder.DoesAccept(fileName))
                {
                    return folder;
                }
            }

            return null;
        }

        internal AlphaFolder Get(int index)
        {
            return _folders[index];
        }

        private void AddFile(string fileName)
        {
            AlphaFolder folder = GetFolderForFile(fileName);
            ListUtils.SortedInsert(folder.Files, fileName);
        }

        private void AddFolder(string start, string end = null)
        {
            AlphaFolder folder = new AlphaFolder(start, end);
            ListUtils.SortedInsert(_folders, folder);
        }

        private void CombineFolders(int indexA, int indexB)
        {
            if (Math.Abs(indexA - indexB) != 1)
            {
                throw new ArgumentException();
            }

            AlphaFolder folderA = _folders[indexA];
            AlphaFolder folderB = _folders[indexB];

            AlphaFolder combined = AlphaFolder.Combine(folderA, folderB);

            _folders.Remove(folderA);
            _folders.Remove(folderB);
            ListUtils.SortedInsert(_folders, combined);
        }

        public static AlphaFolderCollection GetAlphaFolders(IEnumerable<string> fileNames, uint maxFolders)
        {
            if (null == fileNames)
            {
                throw new ArgumentNullException(nameof(fileNames));
            }

            if (maxFolders < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(maxFolders));
            }

            AlphaFolderCollection collection = new AlphaFolderCollection();

            foreach (string fileName in fileNames)
            {
                char firstChar = fileName[0];
                string subDir = char.IsLetter(firstChar) ? firstChar.ToString().ToUpper() : AlphaFolder.NumericAlphaFolder;

                if (!collection.HasFolderForFile(fileName))
                {
                    collection.AddFolder(subDir);
                }

                collection.AddFile(fileName);
            }

            while (collection.Count > maxFolders)
            {
                int minPairIndexA = 0;
                int minPairIndexB = 0;
                int minPairCount = int.MaxValue;

                int minIndex = 0;
                int minCount = int.MaxValue;

                for (int i = 0; i < collection.Count; i++)
                {
                    int count = collection.Get(i).Files.Count;

                    // Find absolute smallest
                    if (count <= minCount)
                    {
                        minIndex = i;
                        minCount = count;
                    }

                    // Find smallest pair
                    if (i + 1 < collection.Count)
                    {
                        int neighborCount = collection.Get(i + 1).Files.Count;
                        if (count + neighborCount <= minPairCount)
                        {
                            minPairIndexA = i;
                            minPairIndexB = i + 1;
                            minPairCount = count + neighborCount;
                        }
                    }
                }

                // Find smallest neighbor to minIndex
                int minNeighborIndex = minIndex;
                if (minNeighborIndex == 0)
                {
                    minNeighborIndex++;
                }
                else if (minNeighborIndex == collection.Count - 1)
                {
                    minNeighborIndex--;
                }
                else
                {
                    int minNeighborLeftCount = collection.Get(minIndex - 1).Files.Count;
                    int minNeighborRightCount = collection.Get(minIndex + 1).Files.Count;

                    if (minNeighborLeftCount <= minNeighborRightCount)
                    {
                        minNeighborIndex--;
                    }
                    else
                    {
                        minNeighborIndex++;
                    }
                }

                int minNeighborCount = collection.Get(minNeighborIndex).Files.Count;

                if (minPairCount < minCount + minNeighborCount)
                {
                    collection.CombineFolders(minPairIndexA, minPairIndexB);
                }
                else
                {
                    collection.CombineFolders(minIndex, minNeighborIndex);
                }
            }

            return collection;
        }
    }
}
