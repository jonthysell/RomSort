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
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

using RomSort.Properties;

namespace RomSort
{
    public partial class MainForm : Form, IRomSortAppView
    {
        public RomSortApp App { get; private set; }

        public string ProgramName
        {
            get
            {
                return string.Format("{0} v{1}", Assembly.GetExecutingAssembly().GetName().Name, Assembly.GetExecutingAssembly().GetName().Version.ToString());
            }
        }

        public string ProgramCopyright
        {
            get
            {
                return ((AssemblyCopyrightAttribute)(Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), true)[0])).Copyright;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Text = ProgramName;
            App = new RomSortApp(this);
            maxDirectoriesUpDown.Value = App.MaxDirectories;
        }

        #region Event Handlers

        private void openEventHandler(object sender, EventArgs e)
        {
            try
            {
                SetBusy();
                App.RootDir = rootDirTextBox.Text;
                if (App.Open())
                {
                    App.Load();
                }
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
                string text = string.Join("\n\n", new string[]{
                    ProgramName,
                    ProgramCopyright,
                    Resources.ProgramLicense,
                });
                MessageBox.Show(text, Resources.AboutCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                bool enableLoad = !string.IsNullOrEmpty(rootDirTextBox.Text);
                loadButton.Enabled = enableLoad;
                loadToolStripMenuItem.Enabled = enableLoad;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void rootDirTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadEventHandler(sender, e);
                e.Handled = true;
            }
        }

        private void maxDirectoriesUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SetBusy();

                uint maxDirectories = (uint)maxDirectoriesUpDown.Value;
                App.MaxDirectories = maxDirectories;

                maxDirectoriesUpDown.ValueChanged -= maxDirectoriesUpDown_ValueChanged;
                maxDirectoriesUpDown.Value = maxDirectories;
                
                App.UpdateDestinationTree();

                maxDirectoriesUpDown.ValueChanged += maxDirectoriesUpDown_ValueChanged;
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
                    bool showDirectoryCounts = App.SourceTreeMetrics.DirectoryCount > 0;
                    sourceMetricsLabel.Text = string.Format(showDirectoryCounts ? Resources.FileDirectoryMetricsLabelFormat : Resources.FileMetricsLabelFormat, App.SourceTreeMetrics.FileCount, App.SourceTreeMetrics.DirectoryCount);
                }
            }

            if ((type & UpdateType.DestinationTree) == UpdateType.DestinationTree)
            {
                destinationTreeView.Nodes.Clear();
                destinationMetricsLabel.Text = "";

                if (null != App.DestinationTree)
                {
                    PopulateTree(destinationTreeView.Nodes, App.DestinationTree);
                    bool showDirectoryCounts = App.DestinationTreeMetrics.DirectoryCount > 0;
                    destinationMetricsLabel.Text = string.Format(showDirectoryCounts ? Resources.FileDirectoryMetricsLabelFormat : Resources.FileMetricsLabelFormat, App.DestinationTreeMetrics.FileCount, App.DestinationTreeMetrics.DirectoryCount);
                }
            }

            sortButton.Enabled = App.CanSort;
            sortToolStripMenuItem.Enabled = App.CanSort;
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

                if (child.IsConflict)
                {
                    tn.ForeColor = Color.Red;
                }

                if (child is DirectoryNode dn)
                {
                    bool showDirectoryCounts = dn.DirectoryCount > 0;
                    tn.Text += string.Format(string.Format(" [{0}]", showDirectoryCounts ? Resources.FileDirectoryMetricsLabelFormat : Resources.FileMetricsLabelFormat), dn.FileCount, dn.DirectoryCount);
                    PopulateTree(tn.Nodes, dn);
                }
            }
        }
    }
}