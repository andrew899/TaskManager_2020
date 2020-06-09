using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Processes
{
    public class ProcessesManger
    {
        private List<ProcessItem> processItems = new List<ProcessItem>();
        public List<ProcessItem> GetProcessItems => processItems;

        private Process[] processes => Process.GetProcesses();
        
        public ProcessesManger()
        {
            foreach(var proc in processes)
            {
                AddProcessToList(proc);
            }
        }

        public void StartNewProcess(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) == false)
                Process.Start(filePath);

            RefreshProcessList();
        }

        public void CloseProcess(Process processToClose)
        {
            processToClose.Kill();

            RefreshProcessList();
        }

        private bool CheckProcessInList(Process processToCheck)
        {
            bool result = false;

            if(processes.Contains(processToCheck))
                result = true;

            return result;
        }

        private void AddProcessToList(Process processIn)
        {
            if(CheckProcessInList(processIn))
                return;

            processItems.Add(new ProcessItem(processIn));
        }

        private void AddProcessToListById(int id)
        {
            AddProcessToList(Process.GetProcessById(id));
        }

        private void DeleteProcessFromList(Process processToDelete)
        {
            var item = processItems.Where(p => p.ProcessId == processToDelete.Id).First();
            if (item != null)
                _ = processItems.Remove(item);
        }

        private void DeleteProcessFromListById(int id)
        {
            var item = processItems.Where(p => p.ProcessId == id).First();
            if (item != null)
                _ = processItems.Remove(item);
        }

        public void RefreshProcessList()
        {
            var processesIdInList =  processItems.Select(p => p.ProcessId);
            var currentProcessesId = processes.Select(p => p.Id);

            if(processesIdInList.Equals(currentProcessesId))
                return;

            var processesToDeleteFromList = processesIdInList.Except(currentProcessesId);

            foreach (var id in processesToDeleteFromList)
            {
                DeleteProcessFromListById(id);
            }

            var processesToAddToList = currentProcessesId.Except(processesIdInList);

            foreach (var id in processesToDeleteFromList)
            {
                AddProcessToListById(id);
            }
        }
    }
}
