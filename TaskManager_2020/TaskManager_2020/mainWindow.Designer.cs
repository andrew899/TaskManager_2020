namespace TaskManager_2020
{
    partial class MainWindow
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
            this.MainWindow_menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManager_timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.processesInfoTab = new System.Windows.Forms.TabPage();
            this.processes_objectListView = new BrightIdeasSoftware.ObjectListView();
            this.ProcessName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ProcessId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Threads = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AllocatedMemory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.newTask_btn = new System.Windows.Forms.Button();
            this.EndTask_btn = new System.Windows.Forms.Button();
            this.systemInfoTab = new System.Windows.Forms.TabPage();
            this.ramUsage_label = new System.Windows.Forms.Label();
            this.cpuUsage_label = new System.Windows.Forms.Label();
            this.ramUsage_progressBar = new System.Windows.Forms.ProgressBar();
            this.cpuUsage_progressBar = new System.Windows.Forms.ProgressBar();
            this.drivesInfoTab = new System.Windows.Forms.TabPage();
            this.drives_listView = new System.Windows.Forms.ListView();
            this.systemInfo_timer = new System.Windows.Forms.Timer(this.components);
            this.MainWindow_menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.processesInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processes_objectListView)).BeginInit();
            this.panel1.SuspendLayout();
            this.systemInfoTab.SuspendLayout();
            this.drivesInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindow_menuStrip
            // 
            this.MainWindow_menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainWindow_menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MainWindow_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MainWindow_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindow_menuStrip.Name = "MainWindow_menuStrip";
            this.MainWindow_menuStrip.Size = new System.Drawing.Size(1272, 42);
            this.MainWindow_menuStrip.TabIndex = 0;
            this.MainWindow_menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshSpeedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshSpeedToolStripMenuItem
            // 
            this.refreshSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.fastToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.refreshSpeedToolStripMenuItem.Name = "refreshSpeedToolStripMenuItem";
            this.refreshSpeedToolStripMenuItem.Size = new System.Drawing.Size(261, 40);
            this.refreshSpeedToolStripMenuItem.Text = "&Refresh speed";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.slowToolStripMenuItem.Text = "&Slow";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Checked = true;
            this.normalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.normalToolStripMenuItem.Text = "&Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.fastToolStripMenuItem.Text = "&Fast";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.stopToolStripMenuItem.Text = "&Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // taskManager_timer
            // 
            this.taskManager_timer.Enabled = true;
            this.taskManager_timer.Interval = 5000;
            this.taskManager_timer.Tick += new System.EventHandler(this.taskManagerTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.processesInfoTab);
            this.tabControl1.Controls.Add(this.systemInfoTab);
            this.tabControl1.Controls.Add(this.drivesInfoTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 900);
            this.tabControl1.TabIndex = 5;
            // 
            // processesInfoTab
            // 
            this.processesInfoTab.Controls.Add(this.processes_objectListView);
            this.processesInfoTab.Controls.Add(this.panel1);
            this.processesInfoTab.Location = new System.Drawing.Point(4, 33);
            this.processesInfoTab.Margin = new System.Windows.Forms.Padding(6);
            this.processesInfoTab.Name = "processesInfoTab";
            this.processesInfoTab.Padding = new System.Windows.Forms.Padding(6);
            this.processesInfoTab.Size = new System.Drawing.Size(1264, 863);
            this.processesInfoTab.TabIndex = 0;
            this.processesInfoTab.Text = "Processes";
            this.processesInfoTab.UseVisualStyleBackColor = true;
            this.processesInfoTab.Click += new System.EventHandler(this.processesInfoTab_Click);
            // 
            // processes_objectListView
            // 
            this.processes_objectListView.AllColumns.Add(this.ProcessName);
            this.processes_objectListView.AllColumns.Add(this.ProcessId);
            this.processes_objectListView.AllColumns.Add(this.Threads);
            this.processes_objectListView.AllColumns.Add(this.AllocatedMemory);
            this.processes_objectListView.CellEditUseWholeCell = false;
            this.processes_objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.ProcessId,
            this.Threads,
            this.AllocatedMemory});
            this.processes_objectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.processes_objectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processes_objectListView.ForeColor = System.Drawing.Color.Black;
            this.processes_objectListView.FullRowSelect = true;
            this.processes_objectListView.GridLines = true;
            this.processes_objectListView.HideSelection = false;
            this.processes_objectListView.Location = new System.Drawing.Point(6, 6);
            this.processes_objectListView.Name = "processes_objectListView";
            this.processes_objectListView.ShowGroups = false;
            this.processes_objectListView.Size = new System.Drawing.Size(1252, 766);
            this.processes_objectListView.TabIndex = 7;
            this.processes_objectListView.UseCompatibleStateImageBehavior = false;
            this.processes_objectListView.View = System.Windows.Forms.View.Details;
            // 
            // ProcessName
            // 
            this.ProcessName.AspectName = "ProcessName";
            this.ProcessName.Text = "Name";
            this.ProcessName.Width = 200;
            // 
            // ProcessId
            // 
            this.ProcessId.AspectName = "Id";
            this.ProcessId.Text = "Id";
            this.ProcessId.Width = 100;
            // 
            // Threads
            // 
            this.Threads.AspectName = "Threads";
            this.Threads.Text = "Threads";
            this.Threads.Width = 100;
            // 
            // AllocatedMemory
            // 
            this.AllocatedMemory.AspectName = "WorkingSet64";
            this.AllocatedMemory.AspectToStringFormat = "“{0:#,##0.0}”";
            this.AllocatedMemory.Text = "Allocated memory";
            this.AllocatedMemory.Width = 200;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.newTask_btn);
            this.panel1.Controls.Add(this.EndTask_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(6, 772);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 85);
            this.panel1.TabIndex = 6;
            // 
            // newTask_btn
            // 
            this.newTask_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newTask_btn.Location = new System.Drawing.Point(12, 18);
            this.newTask_btn.Margin = new System.Windows.Forms.Padding(4);
            this.newTask_btn.Name = "newTask_btn";
            this.newTask_btn.Size = new System.Drawing.Size(123, 57);
            this.newTask_btn.TabIndex = 1;
            this.newTask_btn.Text = "New Task";
            this.newTask_btn.UseVisualStyleBackColor = true;
            this.newTask_btn.Click += new System.EventHandler(this.newTask_btn_Click);
            // 
            // EndTask_btn
            // 
            this.EndTask_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTask_btn.Location = new System.Drawing.Point(1118, 18);
            this.EndTask_btn.Margin = new System.Windows.Forms.Padding(4);
            this.EndTask_btn.Name = "EndTask_btn";
            this.EndTask_btn.Size = new System.Drawing.Size(123, 57);
            this.EndTask_btn.TabIndex = 0;
            this.EndTask_btn.Text = "End Task";
            this.EndTask_btn.UseVisualStyleBackColor = true;
            this.EndTask_btn.Click += new System.EventHandler(this.EndTask_btn_Click);
            // 
            // systemInfoTab
            // 
            this.systemInfoTab.Controls.Add(this.ramUsage_label);
            this.systemInfoTab.Controls.Add(this.cpuUsage_label);
            this.systemInfoTab.Controls.Add(this.ramUsage_progressBar);
            this.systemInfoTab.Controls.Add(this.cpuUsage_progressBar);
            this.systemInfoTab.Location = new System.Drawing.Point(4, 33);
            this.systemInfoTab.Margin = new System.Windows.Forms.Padding(6);
            this.systemInfoTab.Name = "systemInfoTab";
            this.systemInfoTab.Padding = new System.Windows.Forms.Padding(6);
            this.systemInfoTab.Size = new System.Drawing.Size(1264, 863);
            this.systemInfoTab.TabIndex = 1;
            this.systemInfoTab.Text = "System info";
            this.systemInfoTab.UseVisualStyleBackColor = true;
            // 
            // ramUsage_label
            // 
            this.ramUsage_label.AutoSize = true;
            this.ramUsage_label.Location = new System.Drawing.Point(15, 85);
            this.ramUsage_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ramUsage_label.Name = "ramUsage_label";
            this.ramUsage_label.Size = new System.Drawing.Size(118, 25);
            this.ramUsage_label.TabIndex = 3;
            this.ramUsage_label.Text = "RAM Usage";
            // 
            // cpuUsage_label
            // 
            this.cpuUsage_label.AutoSize = true;
            this.cpuUsage_label.Location = new System.Drawing.Point(15, 30);
            this.cpuUsage_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cpuUsage_label.Name = "cpuUsage_label";
            this.cpuUsage_label.Size = new System.Drawing.Size(116, 25);
            this.cpuUsage_label.TabIndex = 2;
            this.cpuUsage_label.Text = "CPU Usage";
            // 
            // ramUsage_progressBar
            // 
            this.ramUsage_progressBar.Location = new System.Drawing.Point(457, 66);
            this.ramUsage_progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.ramUsage_progressBar.Name = "ramUsage_progressBar";
            this.ramUsage_progressBar.Size = new System.Drawing.Size(787, 42);
            this.ramUsage_progressBar.Step = 1;
            this.ramUsage_progressBar.TabIndex = 1;
            // 
            // cpuUsage_progressBar
            // 
            this.cpuUsage_progressBar.Location = new System.Drawing.Point(457, 11);
            this.cpuUsage_progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.cpuUsage_progressBar.Name = "cpuUsage_progressBar";
            this.cpuUsage_progressBar.Size = new System.Drawing.Size(787, 42);
            this.cpuUsage_progressBar.Step = 1;
            this.cpuUsage_progressBar.TabIndex = 0;
            // 
            // drivesInfoTab
            // 
            this.drivesInfoTab.Controls.Add(this.drives_listView);
            this.drivesInfoTab.Location = new System.Drawing.Point(4, 33);
            this.drivesInfoTab.Name = "drivesInfoTab";
            this.drivesInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.drivesInfoTab.Size = new System.Drawing.Size(1264, 863);
            this.drivesInfoTab.TabIndex = 2;
            this.drivesInfoTab.Text = "Drives info";
            this.drivesInfoTab.UseVisualStyleBackColor = true;
            // 
            // drives_listView
            // 
            this.drives_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drives_listView.FullRowSelect = true;
            this.drives_listView.GridLines = true;
            this.drives_listView.HideSelection = false;
            this.drives_listView.Location = new System.Drawing.Point(3, 3);
            this.drives_listView.Margin = new System.Windows.Forms.Padding(6);
            this.drives_listView.Name = "drives_listView";
            this.drives_listView.Size = new System.Drawing.Size(1258, 857);
            this.drives_listView.TabIndex = 5;
            this.drives_listView.UseCompatibleStateImageBehavior = false;
            this.drives_listView.View = System.Windows.Forms.View.Details;
            // 
            // systemInfo_timer
            // 
            this.systemInfo_timer.Enabled = true;
            this.systemInfo_timer.Interval = 5000;
            this.systemInfo_timer.Tick += new System.EventHandler(this.systemInfo_timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 942);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainWindow_menuStrip);
            this.MainMenuStrip = this.MainWindow_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainWindow_menuStrip.ResumeLayout(false);
            this.MainWindow_menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.processesInfoTab.ResumeLayout(false);
            this.processesInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processes_objectListView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.systemInfoTab.ResumeLayout(false);
            this.systemInfoTab.PerformLayout();
            this.drivesInfoTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainWindow_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer taskManager_timer;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage processesInfoTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EndTask_btn;
        private System.Windows.Forms.TabPage systemInfoTab;
        private System.Windows.Forms.Label ramUsage_label;
        private System.Windows.Forms.Label cpuUsage_label;
        private System.Windows.Forms.ProgressBar ramUsage_progressBar;
        private System.Windows.Forms.ProgressBar cpuUsage_progressBar;
        private System.Windows.Forms.Timer systemInfo_timer;
        private System.Windows.Forms.Button newTask_btn;
        private System.Windows.Forms.TabPage drivesInfoTab;
        private System.Windows.Forms.ListView drives_listView;
        private BrightIdeasSoftware.ObjectListView processes_objectListView;
        private BrightIdeasSoftware.OLVColumn ProcessName;
        private BrightIdeasSoftware.OLVColumn ProcessId;
        private BrightIdeasSoftware.OLVColumn Threads;
        private BrightIdeasSoftware.OLVColumn AllocatedMemory;
    }
}

