﻿namespace TaskManager_2020
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
            this.Processes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newTask_btn = new System.Windows.Forms.Button();
            this.EndTask_btn = new System.Windows.Forms.Button();
            this.processes_listView = new System.Windows.Forms.ListView();
            this.SystemInfo = new System.Windows.Forms.TabPage();
            this.drives_listView = new System.Windows.Forms.ListView();
            this.ramUsage_label = new System.Windows.Forms.Label();
            this.cpuUsage_label = new System.Windows.Forms.Label();
            this.ramUsage_progressBar = new System.Windows.Forms.ProgressBar();
            this.cpuUsage_progressBar = new System.Windows.Forms.ProgressBar();
            this.systemInfo_timer = new System.Windows.Forms.Timer(this.components);
            this.cpuUsage_performanceCounter = new System.Diagnostics.PerformanceCounter();
            this.ramUsage_performanceCounter = new System.Diagnostics.PerformanceCounter();
            this.MainWindow_menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Processes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SystemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsage_performanceCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsage_performanceCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWindow_menuStrip
            // 
            this.MainWindow_menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MainWindow_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MainWindow_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindow_menuStrip.Name = "MainWindow_menuStrip";
            this.MainWindow_menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.MainWindow_menuStrip.Size = new System.Drawing.Size(694, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(110, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshSpeedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
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
            this.refreshSpeedToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.refreshSpeedToolStripMenuItem.Text = "&Refresh speed";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.slowToolStripMenuItem.Text = "&Slow";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Checked = true;
            this.normalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "&Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.fastToolStripMenuItem.Text = "&Fast";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            this.tabControl1.Controls.Add(this.Processes);
            this.tabControl1.Controls.Add(this.SystemInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 486);
            this.tabControl1.TabIndex = 5;
            // 
            // Processes
            // 
            this.Processes.Controls.Add(this.panel1);
            this.Processes.Controls.Add(this.processes_listView);
            this.Processes.Location = new System.Drawing.Point(4, 22);
            this.Processes.Name = "Processes";
            this.Processes.Padding = new System.Windows.Forms.Padding(3);
            this.Processes.Size = new System.Drawing.Size(686, 460);
            this.Processes.TabIndex = 0;
            this.Processes.Text = "Processes";
            this.Processes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.newTask_btn);
            this.panel1.Controls.Add(this.EndTask_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 411);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 46);
            this.panel1.TabIndex = 6;
            // 
            // newTask_btn
            // 
            this.newTask_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newTask_btn.Location = new System.Drawing.Point(4, 10);
            this.newTask_btn.Margin = new System.Windows.Forms.Padding(2);
            this.newTask_btn.Name = "newTask_btn";
            this.newTask_btn.Size = new System.Drawing.Size(67, 31);
            this.newTask_btn.TabIndex = 1;
            this.newTask_btn.Text = "New Task";
            this.newTask_btn.UseVisualStyleBackColor = true;
            this.newTask_btn.Click += new System.EventHandler(this.newTask_btn_Click);
            // 
            // EndTask_btn
            // 
            this.EndTask_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTask_btn.Location = new System.Drawing.Point(607, 10);
            this.EndTask_btn.Margin = new System.Windows.Forms.Padding(2);
            this.EndTask_btn.Name = "EndTask_btn";
            this.EndTask_btn.Size = new System.Drawing.Size(67, 31);
            this.EndTask_btn.TabIndex = 0;
            this.EndTask_btn.Text = "End Task";
            this.EndTask_btn.UseVisualStyleBackColor = true;
            this.EndTask_btn.Click += new System.EventHandler(this.EndTask_btn_Click);
            // 
            // processes_listView
            // 
            this.processes_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processes_listView.FullRowSelect = true;
            this.processes_listView.GridLines = true;
            this.processes_listView.HideSelection = false;
            this.processes_listView.Location = new System.Drawing.Point(0, 0);
            this.processes_listView.Margin = new System.Windows.Forms.Padding(2);
            this.processes_listView.Name = "processes_listView";
            this.processes_listView.Size = new System.Drawing.Size(694, 407);
            this.processes_listView.TabIndex = 5;
            this.processes_listView.UseCompatibleStateImageBehavior = false;
            this.processes_listView.View = System.Windows.Forms.View.Details;
            // 
            // SystemInfo
            // 
            this.SystemInfo.Controls.Add(this.drives_listView);
            this.SystemInfo.Controls.Add(this.ramUsage_label);
            this.SystemInfo.Controls.Add(this.cpuUsage_label);
            this.SystemInfo.Controls.Add(this.ramUsage_progressBar);
            this.SystemInfo.Controls.Add(this.cpuUsage_progressBar);
            this.SystemInfo.Location = new System.Drawing.Point(4, 22);
            this.SystemInfo.Name = "SystemInfo";
            this.SystemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.SystemInfo.Size = new System.Drawing.Size(686, 460);
            this.SystemInfo.TabIndex = 1;
            this.SystemInfo.Text = "System info";
            this.SystemInfo.UseVisualStyleBackColor = true;
            // 
            // drives_listView
            // 
            this.drives_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drives_listView.FullRowSelect = true;
            this.drives_listView.GridLines = true;
            this.drives_listView.HideSelection = false;
            this.drives_listView.Location = new System.Drawing.Point(3, 102);
            this.drives_listView.Name = "drives_listView";
            this.drives_listView.Size = new System.Drawing.Size(680, 355);
            this.drives_listView.TabIndex = 4;
            this.drives_listView.UseCompatibleStateImageBehavior = false;
            this.drives_listView.View = System.Windows.Forms.View.Details;
            // 
            // ramUsage_label
            // 
            this.ramUsage_label.AutoSize = true;
            this.ramUsage_label.Location = new System.Drawing.Point(8, 46);
            this.ramUsage_label.Name = "ramUsage_label";
            this.ramUsage_label.Size = new System.Drawing.Size(65, 13);
            this.ramUsage_label.TabIndex = 3;
            this.ramUsage_label.Text = "RAM Usage";
            // 
            // cpuUsage_label
            // 
            this.cpuUsage_label.AutoSize = true;
            this.cpuUsage_label.Location = new System.Drawing.Point(8, 16);
            this.cpuUsage_label.Name = "cpuUsage_label";
            this.cpuUsage_label.Size = new System.Drawing.Size(63, 13);
            this.cpuUsage_label.TabIndex = 2;
            this.cpuUsage_label.Text = "CPU Usage";
            // 
            // ramUsage_progressBar
            // 
            this.ramUsage_progressBar.Location = new System.Drawing.Point(249, 36);
            this.ramUsage_progressBar.Name = "ramUsage_progressBar";
            this.ramUsage_progressBar.Size = new System.Drawing.Size(429, 23);
            this.ramUsage_progressBar.Step = 1;
            this.ramUsage_progressBar.TabIndex = 1;
            // 
            // cpuUsage_progressBar
            // 
            this.cpuUsage_progressBar.Location = new System.Drawing.Point(249, 6);
            this.cpuUsage_progressBar.Name = "cpuUsage_progressBar";
            this.cpuUsage_progressBar.Size = new System.Drawing.Size(429, 23);
            this.cpuUsage_progressBar.Step = 1;
            this.cpuUsage_progressBar.TabIndex = 0;
            // 
            // systemInfo_timer
            // 
            this.systemInfo_timer.Enabled = true;
            this.systemInfo_timer.Tick += new System.EventHandler(this.systemInfo_timer_Tick);
            // 
            // cpuUsage_performanceCounter
            // 
            this.cpuUsage_performanceCounter.CategoryName = "Processor";
            this.cpuUsage_performanceCounter.CounterName = "% Privileged Time";
            this.cpuUsage_performanceCounter.InstanceName = "_Total";
            this.cpuUsage_performanceCounter.MachineName = "DESKTOP-MAIN";
            // 
            // ramUsage_performanceCounter
            // 
            this.ramUsage_performanceCounter.CategoryName = "Memory";
            this.ramUsage_performanceCounter.CounterName = "% Committed Bytes In Use";
            this.ramUsage_performanceCounter.MachineName = "DESKTOP-MAIN";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 510);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainWindow_menuStrip);
            this.MainMenuStrip = this.MainWindow_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainWindow_menuStrip.ResumeLayout(false);
            this.MainWindow_menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Processes.ResumeLayout(false);
            this.Processes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.SystemInfo.ResumeLayout(false);
            this.SystemInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsage_performanceCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsage_performanceCounter)).EndInit();
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
        private System.Windows.Forms.TabPage Processes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EndTask_btn;
        private System.Windows.Forms.ListView processes_listView;
        private System.Windows.Forms.TabPage SystemInfo;
        private System.Windows.Forms.Label ramUsage_label;
        private System.Windows.Forms.Label cpuUsage_label;
        private System.Windows.Forms.ProgressBar ramUsage_progressBar;
        private System.Windows.Forms.ProgressBar cpuUsage_progressBar;
        private System.Windows.Forms.Timer systemInfo_timer;
        private System.Diagnostics.PerformanceCounter cpuUsage_performanceCounter;
        private System.Diagnostics.PerformanceCounter ramUsage_performanceCounter;
        private System.Windows.Forms.Button newTask_btn;
        private System.Windows.Forms.ListView drives_listView;
    }
}

