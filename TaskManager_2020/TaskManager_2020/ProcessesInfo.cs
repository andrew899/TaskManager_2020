using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager_Processes;

namespace TaskManager_2020
{
    public class ProcessesInfo
    {
        private ProcessesManger processes = new ProcessesManger();

        private List<ListViewItem> listViewItems = new List<ListViewItem>();
        public List<ListViewItem> ListViewItems => listViewItems;

        public string[] ColumnNames = new string[]
                {
                    "Name",
                    "Id",
                    "CPU Usage",
                    "RAM Usage"
                };

        public void SetProcessesListView()
        {
            listViewItems.Clear(); // TODO Refresh: old delete, new add

            var allProcesses = processes.GetProcessItems;

            foreach (var p in allProcesses)
            {
                var row = new string[]
                {
                    p.ProcessName,
                    p.ProcessId.ToString(),
                    //p.GetProcessCpuUsage().ToString(),
                    //p.GetProcessRAMUsage().ToString()
                };

                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = p;

                listViewItems.Add(listViewItem);
            }
        }

        public void RefreshProcessInfo()
        {
            if(processes.RefreshProcessList())
                SetProcessesListView();
        }
    }
}
