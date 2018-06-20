// 
// MainForm.cs
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
using System.Reflection;
using System.Windows.Forms;

using RomSort.Properties;

namespace RomSort
{
    public partial class MainForm : Form, IRomSortAppView
    {
        public RomSortApp App { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            Text = string.Format("{0} v{1}", Assembly.GetExecutingAssembly().GetName().Name, Assembly.GetExecutingAssembly().GetName().Version.ToString());
            App = new RomSortApp(this);
        }

        #region Event Handlers

        private void openEventHandler(object sender, EventArgs e)
        {
            try
            {
                SetBusy();
                App.Open();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                SetIdle();
            }
        }

        private void sortEventHandler(object sender, EventArgs e)
        {
            try
            {
                SetBusy();
                App.Sort();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                SetIdle();
            }
        }

        private void exitEventHandler(object sender, EventArgs e)
        {
            try
            {
                App.Exit();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void aboutEventHandler(object sender, EventArgs e)
        {
            try
            {
                SetBusy();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                SetIdle();
            }
        }

        #endregion

        #region IRomSortAppView

        public void HandleException(Exception ex)
        {
            MessageBox.Show(string.Format(Resources.ExceptionTextFormat, ex.Message, ex.StackTrace), Resources.ExceptionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool PromptForConfirmation(string message)
        {
            DialogResult result = MessageBox.Show(message, Resources.PromptForConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return (result == DialogResult.Yes);
        }

        public bool TryPromptForDirectory(string prompt, out string rootDir)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = prompt;

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                rootDir = dialog.SelectedPath;
                return true;
            }

            rootDir = default(string);
            return false;
        }

        public void Update(UpdateType type)
        {
            if ((type & UpdateType.RootDirectory) == UpdateType.RootDirectory)
            {
                rootDirTextBox.Text = App.RootDir;
                sortButton.Enabled = true;
                sortToolStripMenuItem.Enabled = true;
            }

            if ((type & UpdateType.SourceTree) == UpdateType.SourceTree)
            {
                PopulateTree(sourceTreeView, App.SourceTree);
            }

            if ((type & UpdateType.DestinationTree) == UpdateType.DestinationTree)
            {
                PopulateTree(destinationTreeView, App.DestinationTree);
            }
        }

        public void Exit()
        {
            Close();
        }

        #endregion

        private void SetBusy()
        {
            Enabled = false;
            Cursor = Cursors.WaitCursor;
        }

        private void SetIdle()
        {
            Cursor = Cursors.Default;
            Enabled = true;
        }

        private void PopulateTree(TreeView treeView, DirectoryNode rootNode)
        {
            treeView.Nodes.Clear();
            PopulateDirectory(treeView.Nodes, rootNode);
        }

        private void PopulateDirectory(TreeNodeCollection viewTarget, DirectoryNode parent)
        {
            foreach (NodeBase child in parent.Children)
            {
                TreeNode tn = viewTarget.Add(child.Name);

                if (child is DirectoryNode)
                {
                    PopulateDirectory(tn.Nodes, child as DirectoryNode);
                }
            }
        }
    }
}