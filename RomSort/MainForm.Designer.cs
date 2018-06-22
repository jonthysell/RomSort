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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.rootDirLabel = new System.Windows.Forms.Label();
            this.rootDirTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
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
            this.menuStrip.SuspendLayout();
            this.mainTablePanel.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDirectoriesUpDown)).BeginInit();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(618, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.loadToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openEventHandler);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(214, 6);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Enabled = false;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadEventHandler);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Enabled = false;
            this.sortToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.sortToolStripMenuItem.Text = "&Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortEventHandler);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitEventHandler);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
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
            this.mainTablePanel.Controls.Add(this.loadButton, 3, 0);
            this.mainTablePanel.Controls.Add(this.mainSplitContainer, 0, 1);
            this.mainTablePanel.Controls.Add(this.sortButton, 3, 2);
            this.mainTablePanel.Controls.Add(this.maxDirectoriesLabel, 1, 2);
            this.mainTablePanel.Controls.Add(this.maxDirectoriesUpDown, 2, 2);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(0, 35);
            this.mainTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 3;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.Size = new System.Drawing.Size(618, 389);
            this.mainTablePanel.TabIndex = 1;
            // 
            // rootDirLabel
            // 
            this.rootDirLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rootDirLabel.AutoSize = true;
            this.rootDirLabel.Location = new System.Drawing.Point(3, 8);
            this.rootDirLabel.Margin = new System.Windows.Forms.Padding(3);
            this.rootDirLabel.Name = "rootDirLabel";
            this.rootDirLabel.Padding = new System.Windows.Forms.Padding(8);
            this.rootDirLabel.Size = new System.Drawing.Size(156, 41);
            this.rootDirLabel.TabIndex = 0;
            this.rootDirLabel.Text = "Root Directory:";
            this.rootDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rootDirTextBox
            // 
            this.rootDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTablePanel.SetColumnSpan(this.rootDirTextBox, 2);
            this.rootDirTextBox.Location = new System.Drawing.Point(173, 13);
            this.rootDirTextBox.Margin = new System.Windows.Forms.Padding(11);
            this.rootDirTextBox.Name = "rootDirTextBox";
            this.rootDirTextBox.Size = new System.Drawing.Size(286, 30);
            this.rootDirTextBox.TabIndex = 1;
            this.rootDirTextBox.WordWrap = false;
            this.rootDirTextBox.TextChanged += new System.EventHandler(this.rootDirTextBox_TextChanged);
            this.rootDirTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rootDirTextBox_KeyUp);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.AutoSize = true;
            this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openButton.Location = new System.Drawing.Point(473, 3);
            this.openButton.Name = "openButton";
            this.openButton.Padding = new System.Windows.Forms.Padding(8);
            this.openButton.Size = new System.Drawing.Size(53, 51);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openEventHandler);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.AutoSize = true;
            this.loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadButton.Enabled = false;
            this.loadButton.Location = new System.Drawing.Point(532, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Padding = new System.Windows.Forms.Padding(8);
            this.loadButton.Size = new System.Drawing.Size(83, 51);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadEventHandler);
            // 
            // mainSplitContainer
            // 
            this.mainTablePanel.SetColumnSpan(this.mainSplitContainer, 5);
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 57);
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
            this.mainSplitContainer.Size = new System.Drawing.Size(618, 260);
            this.mainSplitContainer.SplitterDistance = 309;
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
            this.leftPanel.Size = new System.Drawing.Size(309, 260);
            this.leftPanel.TabIndex = 0;
            // 
            // sourceMetricsLabel
            // 
            this.sourceMetricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceMetricsLabel.AutoSize = true;
            this.sourceMetricsLabel.Location = new System.Drawing.Point(3, 216);
            this.sourceMetricsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.sourceMetricsLabel.Name = "sourceMetricsLabel";
            this.sourceMetricsLabel.Padding = new System.Windows.Forms.Padding(8);
            this.sourceMetricsLabel.Size = new System.Drawing.Size(303, 41);
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
            this.sourceLabel.Size = new System.Drawing.Size(303, 41);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "Original";
            this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceTreeView
            // 
            this.sourceTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTreeView.Location = new System.Drawing.Point(3, 50);
            this.sourceTreeView.Name = "sourceTreeView";
            this.sourceTreeView.Size = new System.Drawing.Size(303, 160);
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
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 3;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightPanel.Size = new System.Drawing.Size(300, 260);
            this.rightPanel.TabIndex = 0;
            // 
            // destinationMetricsLabel
            // 
            this.destinationMetricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationMetricsLabel.AutoSize = true;
            this.destinationMetricsLabel.Location = new System.Drawing.Point(3, 216);
            this.destinationMetricsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.destinationMetricsLabel.Name = "destinationMetricsLabel";
            this.destinationMetricsLabel.Padding = new System.Windows.Forms.Padding(8);
            this.destinationMetricsLabel.Size = new System.Drawing.Size(294, 41);
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
            this.destinationLabel.Size = new System.Drawing.Size(294, 41);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Sort Preview";
            this.destinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationTreeView
            // 
            this.destinationTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationTreeView.Location = new System.Drawing.Point(3, 50);
            this.destinationTreeView.Name = "destinationTreeView";
            this.destinationTreeView.Size = new System.Drawing.Size(294, 160);
            this.destinationTreeView.TabIndex = 2;
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.AutoSize = true;
            this.sortButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTablePanel.SetColumnSpan(this.sortButton, 2);
            this.sortButton.Enabled = false;
            this.sortButton.Location = new System.Drawing.Point(473, 327);
            this.sortButton.Name = "sortButton";
            this.sortButton.Padding = new System.Windows.Forms.Padding(8);
            this.sortButton.Size = new System.Drawing.Size(142, 51);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortEventHandler);
            // 
            // maxDirectoriesLabel
            // 
            this.maxDirectoriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maxDirectoriesLabel.AutoSize = true;
            this.maxDirectoriesLabel.Location = new System.Drawing.Point(165, 320);
            this.maxDirectoriesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.maxDirectoriesLabel.Name = "maxDirectoriesLabel";
            this.maxDirectoriesLabel.Padding = new System.Windows.Forms.Padding(8);
            this.maxDirectoriesLabel.Size = new System.Drawing.Size(148, 66);
            this.maxDirectoriesLabel.TabIndex = 5;
            this.maxDirectoriesLabel.Text = "Max Directories:";
            this.maxDirectoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxDirectoriesUpDown
            // 
            this.maxDirectoriesUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxDirectoriesUpDown.AutoSize = true;
            this.maxDirectoriesUpDown.Location = new System.Drawing.Point(319, 338);
            this.maxDirectoriesUpDown.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.maxDirectoriesUpDown.Name = "maxDirectoriesUpDown";
            this.maxDirectoriesUpDown.Size = new System.Drawing.Size(58, 30);
            this.maxDirectoriesUpDown.TabIndex = 6;
            this.maxDirectoriesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxDirectoriesUpDown.ValueChanged += new System.EventHandler(this.maxDirectoriesUpDown_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.mainTablePanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TreeView sourceTreeView;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TreeView destinationTreeView;
        private System.Windows.Forms.Label sourceMetricsLabel;
        private System.Windows.Forms.Label destinationMetricsLabel;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label maxDirectoriesLabel;
        private System.Windows.Forms.NumericUpDown maxDirectoriesUpDown;
    }
}

