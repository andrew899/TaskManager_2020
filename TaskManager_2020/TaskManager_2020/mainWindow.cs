 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager_2020
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Process[] proc;
        void GetAllProcess()
        {
            proc = Process.GetProcesses();

            Processes_listView.Items.Clear();
            
            foreach (Process p in proc)
            {
                var row = new string[] { p.ProcessName, p.Id.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = p;

                Processes_listView.Items.Add(listViewItem);
            }

            Processes_listView.Sorting = SortOrder.Ascending;

            Processes_listView.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void EndTask_btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (var i = 0; i < Processes_listView.SelectedItems.Count; i++)
                {
                    var process = Processes_listView.SelectedItems[i].Tag as Process;
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
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void taskManagerTimer_Tick(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskManager_timer.Interval = 10000;

            taskManager_timer.Enabled = true;

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

        private void systemInfo_timer_Tick(object sender, EventArgs e)
        {
            cpuUsage_progressBar.Value = (int)cpuUsage_performanceCounter.NextValue();
            cpuUsage_label.Text ="CPU usage: " + cpuUsage_progressBar.Value.ToString() + " %";
            
            ramUsage_progressBar.Value = (int)ramUsage_performanceCounter.NextValue();
            ramUsage_label.Text = "RAM usage: " + ramUsage_progressBar.Value.ToString() + " %";
        }

        
    }
}
