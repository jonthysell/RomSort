namespace RomSort
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.rootDirLabel = new System.Windows.Forms.Label();
            this.rootDirTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sourceMetricsLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceTreeView = new System.Windows.Forms.TreeView();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.destinationMetricsLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationTreeView = new System.Windows.Forms.TreeView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.topTablePanel.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.sortToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openEventHandler);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Enabled = false;
            this.sortToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sortToolStripMenuItem.Text = "&Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortEventHandler);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitEventHandler);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutEventHandler);
            // 
            // topTablePanel
            // 
            this.topTablePanel.AutoSize = true;
            this.topTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topTablePanel.ColumnCount = 4;
            this.topTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTablePanel.Controls.Add(this.rootDirLabel, 0, 0);
            this.topTablePanel.Controls.Add(this.rootDirTextBox, 1, 0);
            this.topTablePanel.Controls.Add(this.openButton, 2, 0);
            this.topTablePanel.Controls.Add(this.sortButton, 3, 0);
            this.topTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTablePanel.Location = new System.Drawing.Point(0, 24);
            this.topTablePanel.Name = "topTablePanel";
            this.topTablePanel.RowCount = 1;
            this.topTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.topTablePanel.Size = new System.Drawing.Size(624, 39);
            this.topTablePanel.TabIndex = 1;
            // 
            // rootDirLabel
            // 
            this.rootDirLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rootDirLabel.AutoSize = true;
            this.rootDirLabel.Location = new System.Drawing.Point(3, 8);
            this.rootDirLabel.Margin = new System.Windows.Forms.Padding(3);
            this.rootDirLabel.Name = "rootDirLabel";
            this.rootDirLabel.Padding = new System.Windows.Forms.Padding(5);
            this.rootDirLabel.Size = new System.Drawing.Size(88, 23);
            this.rootDirLabel.TabIndex = 0;
            this.rootDirLabel.Text = "Root Directory:";
            this.rootDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rootDirTextBox
            // 
            this.rootDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rootDirTextBox.Location = new System.Drawing.Point(102, 9);
            this.rootDirTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.rootDirTextBox.Name = "rootDirTextBox";
            this.rootDirTextBox.ReadOnly = true;
            this.rootDirTextBox.Size = new System.Drawing.Size(420, 20);
            this.rootDirTextBox.TabIndex = 1;
            this.rootDirTextBox.WordWrap = false;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.AutoSize = true;
            this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openButton.Location = new System.Drawing.Point(533, 3);
            this.openButton.Name = "openButton";
            this.openButton.Padding = new System.Windows.Forms.Padding(5);
            this.openButton.Size = new System.Drawing.Size(36, 33);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openEventHandler);
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.AutoSize = true;
            this.sortButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sortButton.Enabled = false;
            this.sortButton.Location = new System.Drawing.Point(575, 3);
            this.sortButton.Name = "sortButton";
            this.sortButton.Padding = new System.Windows.Forms.Padding(5);
            this.sortButton.Size = new System.Drawing.Size(46, 33);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortEventHandler);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 63);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.leftPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.rightPanel);
            this.mainSplitContainer.Size = new System.Drawing.Size(624, 356);
            this.mainSplitContainer.SplitterDistance = 312;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Controls.Add(this.sourceMetricsLabel, 0, 2);
            this.leftPanel.Controls.Add(this.sourceLabel, 0, 0);
            this.leftPanel.Controls.Add(this.sourceTreeView, 0, 1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.RowCount = 3;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.Size = new System.Drawing.Size(312, 356);
            this.leftPanel.TabIndex = 0;
            // 
            // sourceMetricsLabel
            // 
            this.sourceMetricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceMetricsLabel.AutoSize = true;
            this.sourceMetricsLabel.Location = new System.Drawing.Point(3, 330);
            this.sourceMetricsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sourceMetricsLabel.Name = "sourceMetricsLabel";
            this.sourceMetricsLabel.Padding = new System.Windows.Forms.Padding(5);
            this.sourceMetricsLabel.Size = new System.Drawing.Size(306, 23);
            this.sourceMetricsLabel.TabIndex = 2;
            this.sourceMetricsLabel.Text = "No directory selected.";
            this.sourceMetricsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceLabel
            // 
            this.sourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(3, 3);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Padding = new System.Windows.Forms.Padding(5);
            this.sourceLabel.Size = new System.Drawing.Size(306, 23);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "Original";
            this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceTreeView
            // 
            this.sourceTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTreeView.Location = new System.Drawing.Point(3, 32);
            this.sourceTreeView.Name = "sourceTreeView";
            this.sourceTreeView.Size = new System.Drawing.Size(306, 292);
            this.sourceTreeView.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Controls.Add(this.destinationMetricsLabel, 0, 2);
            this.rightPanel.Controls.Add(this.destinationLabel, 0, 0);
            this.rightPanel.Controls.Add(this.destinationTreeView, 0, 1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 3;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightPanel.Size = new System.Drawing.Size(308, 356);
            this.rightPanel.TabIndex = 0;
            // 
            // destinationMetricsLabel
            // 
            this.destinationMetricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationMetricsLabel.AutoSize = true;
            this.destinationMetricsLabel.Location = new System.Drawing.Point(3, 330);
            this.destinationMetricsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.destinationMetricsLabel.Name = "destinationMetricsLabel";
            this.destinationMetricsLabel.Padding = new System.Windows.Forms.Padding(5);
            this.destinationMetricsLabel.Size = new System.Drawing.Size(302, 23);
            this.destinationMetricsLabel.TabIndex = 3;
            this.destinationMetricsLabel.Text = "No directory selected.";
            this.destinationMetricsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationLabel
            // 
            this.destinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(3, 3);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Padding = new System.Windows.Forms.Padding(5);
            this.destinationLabel.Size = new System.Drawing.Size(302, 23);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Sort Preview";
            this.destinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationTreeView
            // 
            this.destinationTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationTreeView.Location = new System.Drawing.Point(3, 32);
            this.destinationTreeView.Name = "destinationTreeView";
            this.destinationTreeView.Size = new System.Drawing.Size(302, 292);
            this.destinationTreeView.TabIndex = 2;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.topTablePanel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "RomSort";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.topTablePanel.ResumeLayout(false);
            this.topTablePanel.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel topTablePanel;
        private System.Windows.Forms.Label rootDirLabel;
        private System.Windows.Forms.TextBox rootDirTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TreeView sourceTreeView;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TreeView destinationTreeView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label sourceMetricsLabel;
        private System.Windows.Forms.Label destinationMetricsLabel;
    }
}

