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
                App.Load();
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

        private void loadEventHandler(object sender, EventArgs e)
        {
            try
            {
                SetBusy();
                App.RootDir = rootDirTextBox.Text;
                App.Load();
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

        private void rootDirTextBox_TextChanged(object sender, EventArgs e)
        {
            loadButton.Enabled = !string.IsNullOrEmpty(rootDirTextBox.Text);
        }

        private void rootDirTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadEventHandler(sender, e);
                e.Handled = true;
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

        public bool TryPromptForDirectory(string prompt, out string rootDir, string defaultPath = "")
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = prompt;
            dialog.SelectedPath = defaultPath;

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
            }

            if ((type & UpdateType.SourceTree) == UpdateType.SourceTree)
            {
                sourceTreeView.Nodes.Clear();
                sourceMetricsLabel.Text = "";

                if (null != App.SourceTree)
                {
                    PopulateTree(sourceTreeView.Nodes, App.SourceTree);
                    sourceMetricsLabel.Text = string.Format(Resources.MetricsLabelFormat, App.SourceTreeMetrics.FileCount, App.SourceTreeMetrics.DirectoryCount);
                }
            }

            if ((type & UpdateType.DestinationTree) == UpdateType.DestinationTree)
            {
                destinationTreeView.Nodes.Clear();
                destinationMetricsLabel.Text = "";

                if (null != App.DestinationTree)
                {
                    PopulateTree(destinationTreeView.Nodes, App.DestinationTree);
                    destinationMetricsLabel.Text = string.Format(Resources.MetricsLabelFormat, App.DestinationTreeMetrics.FileCount, App.DestinationTreeMetrics.DirectoryCount);

                    sortToolStripMenuItem.Enabled = true;
                }
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

        private void PopulateTree(TreeNodeCollection viewTarget, DirectoryNode node)
        {
            foreach (NodeBase child in node.Children)
            {
                TreeNode tn = viewTarget.Add(child.Name);

                if (child is DirectoryNode)
                {
                    PopulateTree(tn.Nodes, child as DirectoryNode);
                }
            }
        }
    }
}