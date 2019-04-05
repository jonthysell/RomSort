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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.rootDirLabel = new System.Windows.Forms.Label();
            this.rootDirTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sourceMetricsLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceTreeView = new System.Windows.Forms.TreeView();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.destinationMetricsLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationTreeView = new System.Windows.Forms.TreeView();
            this.sortButton = new System.Windows.Forms.Button();
            this.maxDirectoriesLabel = new System.Windows.Forms.Label();
            this.maxDirectoriesUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.nodesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.mainTablePanel.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDirectoriesUpDown)).BeginInit();
            this.nodesContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.refreshToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openEventHandler);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Enabled = false;
            this.sortToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sortToolStripMenuItem.Text = "&Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortEventHandler);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutToolStripMenuItem.Text = "&About RomSort";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutEventHandler);
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.AutoSize = true;
            this.mainTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTablePanel.ColumnCount = 5;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTablePanel.Controls.Add(this.rootDirLabel, 0, 0);
            this.mainTablePanel.Controls.Add(this.rootDirTextBox, 1, 0);
            this.mainTablePanel.Controls.Add(this.openButton, 2, 0);
            this.mainTablePanel.Controls.Add(this.mainSplitContainer, 0, 1);
            this.mainTablePanel.Controls.Add(this.sortButton, 3, 2);
            this.mainTablePanel.Controls.Add(this.maxDirectoriesLabel, 1, 2);
            this.mainTablePanel.Controls.Add(this.maxDirectoriesUpDown, 2, 2);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(0, 24);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainTablePanel.RowCount = 3;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTablePanel.Size = new System.Drawing.Size(624, 395);
            this.mainTablePanel.TabIndex = 1;
            // 
            // rootDirLabel
            // 
            this.rootDirLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rootDirLabel.AutoSize = true;
            this.rootDirLabel.Location = new System.Drawing.Point(13, 18);
            this.rootDirLabel.Margin = new System.Windows.Forms.Padding(3);
            this.rootDirLabel.Name = "rootDirLabel";
            this.rootDirLabel.Padding = new System.Windows.Forms.Padding(8);
            this.rootDirLabel.Size = new System.Drawing.Size(119, 33);
            this.rootDirLabel.TabIndex = 0;
            this.rootDirLabel.Text = "Root Directory:";
            this.rootDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rootDirTextBox
            // 
            this.rootDirTextBox.AllowDrop = true;
            this.rootDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTablePanel.SetColumnSpan(this.rootDirTextBox, 2);
            this.rootDirTextBox.Location = new System.Drawing.Point(146, 23);
            this.rootDirTextBox.Margin = new System.Windows.Forms.Padding(11);
            this.rootDirTextBox.Name = "rootDirTextBox";
            this.rootDirTextBox.ReadOnly = true;
            this.rootDirTextBox.Size = new System.Drawing.Size(382, 23);
            this.rootDirTextBox.TabIndex = 1;
            this.rootDirTextBox.WordWrap = false;
            this.rootDirTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropEventHandler);
            this.rootDirTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterEventHandler);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.AutoSize = true;
            this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTablePanel.SetColumnSpan(this.openButton, 2);
            this.openButton.Location = new System.Drawing.Point(542, 13);
            this.openButton.Name = "openButton";
            this.openButton.Padding = new System.Windows.Forms.Padding(8);
            this.openButton.Size = new System.Drawing.Size(69, 43);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openEventHandler);
            // 
            // mainSplitContainer
            // 
            this.mainTablePanel.SetColumnSpan(this.mainSplitContainer, 5);
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(10, 59);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.leftPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.rightPanel);
            this.mainSplitContainer.Size = new System.Drawing.Size(604, 277);
            this.mainSplitContainer.SplitterDistance = 302;
            this.mainSplitContainer.SplitterWidth = 9;
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
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.RowCount = 3;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.Size = new System.Drawing.Size(302, 277);
            this.leftPanel.TabIndex = 0;
            // 
            // sourceMetricsLabel
            // 
            this.sourceMetricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceMetricsLabel.AutoSize = true;
            this.sourceMetricsLabel.Location = new System.Drawing.Point(3, 241);
            this.sourceMetricsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sourceMetricsLabel.Name = "sourceMetricsLabel";
            this.sourceMetricsLabel.Padding = new System.Windows.Forms.Padding(8);
            this.sourceMetricsLabel.Size = new System.Drawing.Size(296, 33);
            this.sourceMetricsLabel.TabIndex = 2;
            this.sourceMetricsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceLabel
            // 
            this.sourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(3, 3);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Padding = new System.Windows.Forms.Padding(8);
            this.sourceLabel.Size = new System.Drawing.Size(296, 33);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "Original";
            this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceTreeView
            // 
            this.sourceTreeView.AllowDrop = true;
            this.sourceTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTreeView.Location = new System.Drawing.Point(3, 42);
            this.sourceTreeView.Name = "sourceTreeView";
            this.sourceTreeView.Size = new System.Drawing.Size(296, 193);
            this.sourceTreeView.TabIndex = 1;
            this.sourceTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.sourceTreeView_NodeMouseClick);
            this.sourceTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.sourceTreeView_NodeMouseDoubleClick);
            this.sourceTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropEventHandler);
            this.sourceTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnterEventHandler);
            this.sourceTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sourceTreeView_KeyDown);
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
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 3;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightPanel.Size = new System.Drawing.Size(293, 277);
            this.rightPanel.TabIndex = 0;
            // 
            // destinationMetricsLabel
            // 
            this.destinationMetricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationMetricsLabel.AutoSize = true;
            this.destinationMetricsLabel.Location = new System.Drawing.Point(3, 241);
            this.destinationMetricsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.destinationMetricsLabel.Name = "destinationMetricsLabel";
            this.destinationMetricsLabel.Padding = new System.Windows.Forms.Padding(8);
            this.destinationMetricsLabel.Size = new System.Drawing.Size(287, 33);
            this.destinationMetricsLabel.TabIndex = 3;
            this.destinationMetricsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationLabel
            // 
            this.destinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(3, 3);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Padding = new System.Windows.Forms.Padding(8);
            this.destinationLabel.Size = new System.Drawing.Size(287, 33);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Sort Preview";
            this.destinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationTreeView
            // 
            this.destinationTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationTreeView.Location = new System.Drawing.Point(3, 42);
            this.destinationTreeView.Name = "destinationTreeView";
            this.destinationTreeView.Size = new System.Drawing.Size(287, 193);
            this.destinationTreeView.TabIndex = 2;
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.AutoSize = true;
            this.sortButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTablePanel.SetColumnSpan(this.sortButton, 2);
            this.sortButton.Enabled = false;
            this.sortButton.Location = new System.Drawing.Point(542, 339);
            this.sortButton.Name = "sortButton";
            this.sortButton.Padding = new System.Windows.Forms.Padding(8);
            this.sortButton.Size = new System.Drawing.Size(69, 43);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortEventHandler);
            // 
            // maxDirectoriesLabel
            // 
            this.maxDirectoriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maxDirectoriesLabel.AutoSize = true;
            this.maxDirectoriesLabel.Location = new System.Drawing.Point(138, 344);
            this.maxDirectoriesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.maxDirectoriesLabel.Name = "maxDirectoriesLabel";
            this.maxDirectoriesLabel.Padding = new System.Windows.Forms.Padding(8);
            this.maxDirectoriesLabel.Size = new System.Drawing.Size(196, 33);
            this.maxDirectoriesLabel.TabIndex = 5;
            this.maxDirectoriesLabel.Text = "Max Directories:";
            this.maxDirectoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxDirectoriesUpDown
            // 
            this.maxDirectoriesUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxDirectoriesUpDown.AutoSize = true;
            this.maxDirectoriesUpDown.Location = new System.Drawing.Point(340, 349);
            this.maxDirectoriesUpDown.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.maxDirectoriesUpDown.Name = "maxDirectoriesUpDown";
            this.maxDirectoriesUpDown.Size = new System.Drawing.Size(40, 23);
            this.maxDirectoriesUpDown.TabIndex = 6;
            this.maxDirectoriesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxDirectoriesUpDown.ValueChanged += new System.EventHandler(this.maxDirectoriesUpDown_ValueChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // nodesContextMenuStrip
            // 
            this.nodesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNodeToolStripMenuItem});
            this.nodesContextMenuStrip.Name = "nodesContextMenuStrip";
            this.nodesContextMenuStrip.Size = new System.Drawing.Size(104, 26);
            // 
            // openNodeToolStripMenuItem
            // 
            this.openNodeToolStripMenuItem.Name = "openNodeToolStripMenuItem";
            this.openNodeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openNodeToolStripMenuItem.Text = "&Open";
            this.openNodeToolStripMenuItem.Click += new System.EventHandler(this.openNodeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.mainTablePanel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "RomSort";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainTablePanel.ResumeLayout(false);
            this.mainTablePanel.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDirectoriesUpDown)).EndInit();
            this.nodesContextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.Label rootDirLabel;
        private System.Windows.Forms.TextBox rootDirTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TreeView sourceTreeView;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TreeView destinationTreeView;
        private System.Windows.Forms.Label sourceMetricsLabel;
        private System.Windows.Forms.Label destinationMetricsLabel;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label maxDirectoriesLabel;
        private System.Windows.Forms.NumericUpDown maxDirectoriesUpDown;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip nodesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openNodeToolStripMenuItem;
    }
}

