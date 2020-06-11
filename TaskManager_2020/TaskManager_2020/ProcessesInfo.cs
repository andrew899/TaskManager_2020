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
        private static ProcessesManger processes = new ProcessesManger();

        public List<ProcessItem> processItems => processes.ProcessItemsCurrent;
        public List<ProcessItem> processItemsNew => processes.GetNewProcessItems();
        public List<ProcessItem> processItemsOld => processes.GetOldProcessItems();

        public void NewProcess(string path) => processes.StartNewProcess(path);
        public void EndProcess(int id) => processes.CloseProcess(id);
    }
}
