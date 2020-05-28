using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace TaskManager_2020
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            CheckDrivesInfo();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void CheckCPUPerformanceInfo()
        {
            cpuUsage_progressBar.Value = CPUPerformance.GetCPUTatalUsageInPercent;
            cpuUsage_label.Text = "CPU usage: " + cpuUsage_progressBar.Value.ToString() + " %";
        }
        
        private void CheckRAMPerformanceInfo()
        {
            ramUsage_progressBar.Value = RAMPerformance.GetRamUsage;
            ramUsage_label.Text = "RAM usage: " + ramUsage_progressBar.Value.ToString() + " %";
        }

        private void CheckDrivesInfo()
        {
            var drives = new DrivesInfo();
            SetDrivesListViewColumns(drives.GetColumnNames);
            SetDrivesInfoToView(drives.GetListAllDrives());
        }

        private void SetDrivesInfoToView(List<ListViewItem> list)
        {
            drives_listView.Items.Clear();

            foreach (var item in list)
            {
                drives_listView.Items.Add(item);
            }
        }

        private void SetProcessListViewColumns(string[] columnNames)
        {
            foreach(var name in columnNames)
            {
                processes_listView.Columns.Add(name, 100, HorizontalAlignment.Center);
            }

            processes_listView.FullRowSelect = true;
            processes_listView.GridLines = true;
            processes_listView.View = View.Details;
        }

        private void SetDrivesListViewColumns(string[] columnNames)
        {
            if (processes_listView.Columns.Count > 0)
                return;

            foreach (var name in columnNames)
            {
                drives_listView.Columns.Add(name, 100, HorizontalAlignment.Center);
            }

            drives_listView.FullRowSelect = true;
            drives_listView.GridLines = true;
            drives_listView.View = View.Details;
        }

        

        void GetAllProcess()
        {
            var columnNames = new string[]
                {
                    "Name",
                    "Id",
                    "Base priority"
                };
            SetProcessListViewColumns(columnNames);

            var proc = Process.GetProcesses();

            processes_listView.Items.Clear();
            
            foreach (Process p in proc)
            {
                var row = new string[] { p.ProcessName, p.Id.ToString(), p.BasePriority.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = p;

                processes_listView.Items.Add(listViewItem);
            }

            processes_listView.Sorting = SortOrder.Ascending;

            processes_listView.Show();
        }



        private void EndTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (var i = 0; i < processes_listView.SelectedItems.Count; i++)
                {
                    var process = processes_listView.SelectedItems[i].Tag as Process;
                    if(process != null)
                        process.Kill();
                }

                Thread.Sleep(50); // Whithout pause Item stays in list till next refresh.

                GetAllProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newTask_btn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            if(string.IsNullOrEmpty(filePath) == false)
                Process.Start(filePath);

            GetAllProcess();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllProcess();
            
            CheckDrivesInfo();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskManager_timer.Interval = 10000;
            taskManager_timer.Enabled = true;

            systemInfo_timer.Interval = 10000;
            systemInfo_timer.Enabled = true;

            var item = sender as ToolStripMenuItem;
            if (item != null)
            {
                ViewSpeedToolTipsCheckedFalse();
                item.Checked = true;
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskManager_timer.Interval = 5000;
            taskManager_timer.Enabled = true;

            systemInfo_timer.Interval = 5000;
            systemInfo_timer.Enabled = true;

            var item = sender as ToolStripMenuItem;
            if (item != null)
            {
                ViewSpeedToolTipsCheckedFalse();
                item.Checked = true;
            }
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskManager_timer.Interval = 1000;
            taskManager_timer.Enabled = true;

            systemInfo_timer.Interval = 1000;
            systemInfo_timer.Enabled = true;

            var item = sender as ToolStripMenuItem;
            if (item != null)
            {
                ViewSpeedToolTipsCheckedFalse();
                item.Checked = true;
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskManager_timer.Enabled = false;

            var item = sender as ToolStripMenuItem;
            if (item != null)
            {
                ViewSpeedToolTipsCheckedFalse();
                item.Checked = true;
            }
        }

        private void ViewSpeedToolTipsCheckedFalse()
        {
            slowToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            fastToolStripMenuItem.Checked = false;
            stopToolStripMenuItem.Checked = false;
        }

        private void taskManagerTimer_Tick(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void systemInfo_timer_Tick(object sender, EventArgs e)
        {
            CheckCPUPerformanceInfo();
            CheckRAMPerformanceInfo();
        }
    }
}
