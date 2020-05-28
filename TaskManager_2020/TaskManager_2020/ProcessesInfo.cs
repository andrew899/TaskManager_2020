using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager_2020
{
    public class ProcessesInfo
    {
        public string[] ColumnNames = new string[]
                {
                    "Name",
                    "Id",
                    "Base priority"
                };

        public List<ListViewItem> GetAllProcess()
        {
            List<ListViewItem> result = new List<ListViewItem>();

            var allProcesses = Process.GetProcesses();

            foreach (Process p in allProcesses)
            {
                var row = new string[]
                {
                    p.ProcessName,
                    p.Id.ToString(),
                    p.BasePriority.ToString()
                };

                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = p;

                result.Add(listViewItem);
            }

            return result;
        }
    }
}
