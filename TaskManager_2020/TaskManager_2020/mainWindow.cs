using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using TaskManager_Processes;

namespace TaskManager_2020
{
    public partial class MainWindow : Form
    {
        private ProcessesInfo processes = new ProcessesInfo();
        public MainWindow()
        {
            InitializeComponent();

            CheckDrivesInfo();

            CheckCPUPerformanceInfo();
            CheckRAMPerformanceInfo();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            processes_objectListView.SetObjects(processes.processItems);
        }

        // Systeminfo
        private void CheckCPUPerformanceInfo()
        {
            var value = CPUPerformance.GetCPUTatalUsageInPercent;
            cpuUsage_progressBar.Value = value;
            cpuUsage_label.Text = "CPU usage: " + cpuUsage_progressBar.Value.ToString() + " %";
            CpuAndRamUsage_chart.Series["CPU"].Points.AddY(value);
        }
        
        private void CheckRAMPerformanceInfo()
        {
            var value = RAMPerformance.GetRamUsage;
            ramUsage_progressBar.Value = value;
            ramUsage_label.Text = "RAM usage: " + ramUsage_progressBar.Value.ToString() + " %";
            CpuAndRamUsage_chart.Series["RAM"].Points.AddY(value);
        }

        private void CheckDrivesInfo()
        {
            var drives = new DrivesInfo();
            SetDrivesListViewColumns(drives.GetColumnNames);
            SetDrivesInfoToView(drives.GetListAllDrives());
        }

        private void SetDrivesListViewColumns(string[] columnNames)
        {
            if (drives_listView.Columns.Count > 0)
                return;

            foreach (var name in columnNames)
            {
                drives_listView.Columns.Add(name, 100, HorizontalAlignment.Center);
            }

            drives_listView.FullRowSelect = true;
            drives_listView.GridLines = true;
            drives_listView.View = View.Details;
        }

        private void SetDrivesInfoToView(List<ListViewItem> list)
        {
            drives_listView.Items.Clear();

            foreach (var item in list)
            {
                drives_listView.Items.Add(item);
            }

            drives_listView.Show();
        }

        // Processes
       
       
        // Menu
        private void EndTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var objectsToClose = processes_objectListView.SelectedItems;

                for (var i = 0; i < objectsToClose.Count; i++)
                {
                    var process = processes_objectListView.SelectedItems[i].SubItems[1].Text;
                    int id;
                    if(Int32.TryParse(process, out id))
                        processes.EndProcess(id);

                    processes_objectListView.SelectedItems[i].Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshListView();
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

            RefreshListView();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processes_objectListView.RemoveObjects(processes.processItemsOld);
            processes_objectListView.AddObjects(processes.processItemsNew);

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

        // Timers
        private void taskManagerTimer_Tick(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void systemInfo_timer_Tick(object sender, EventArgs e)
        {
            CheckCPUPerformanceInfo();
            CheckRAMPerformanceInfo();
        }

        private void RefreshListView()
        {
            var itemsToDelete = processes.processItemsOld;
            processes_objectListView.RemoveObjects(itemsToDelete);

            var itemsToAdd = processes.processItemsNew;
            processes_objectListView.AddObjects(itemsToAdd);
        }

        private void processesInfoTab_Click(object sender, EventArgs e)
        {
        }
    }
}
