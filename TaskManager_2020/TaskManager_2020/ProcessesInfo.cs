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

        public string[] ColumnNames = new string[]
                {
                    "Name",
                    "Id",
                    "CPU Usage",
                    "RAM Usage"
                };

        public List<ListViewItem> GetAllProcess()
        {
            List<ListViewItem> result = new List<ListViewItem>();

            var allProcesses = processes.GetProcessItems;

            foreach (var p in allProcesses)
            {
                var row = new string[]
                {
                    p.ProcessName,
                    p.ProcessId.ToString(),
                    p.ProcessCpuUsage.ToString(),
                    p.ProcessRAMUsage.ToString()
                };

                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = p;

                result.Add(listViewItem);
            }

            return result;
        }
    }
}
