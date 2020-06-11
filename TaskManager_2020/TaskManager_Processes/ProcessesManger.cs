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
        private Process[] processesCurrent => Process.GetProcesses();

        private List<ProcessItem> processItemsCurrent = new List<ProcessItem>();

        public List<ProcessItem> ProcessItemsCurrent => processItemsCurrent;

        public ProcessesManger()
        {
            foreach(var proc in processesCurrent)
            {
                AddProcessToList(proc);
            }
        }

        public List<ProcessItem> GetOldProcessItems()
            {
                var itemsIds = processItemsCurrent.Select(p => p.Id);
                var processesIds = processesCurrent.Select(pc => pc.Id);
                
                var oldIds = itemsIds.Except(processesIds);
                
                var oldItems = processItemsCurrent.Where(pi => oldIds.Contains(pi.Id)).ToList();

                DeleteProcessFromList(oldItems);

                return oldItems;
            }

        public List<ProcessItem> GetNewProcessItems()
        {
            var currentProcs = processesCurrent;

            var itemsIds = processItemsCurrent.Select(p => p.Id);
            var processesIds = processesCurrent.Select(pc => pc.Id);

            var newIds = processesIds.Except(itemsIds);

            var newProcesses = currentProcs.Where(cp => newIds.Contains(cp.Id)).ToArray();

            AddProcessToList(newProcesses);
            
            return GetNewProcessItems(newProcesses);
        }

        private List<ProcessItem> GetNewProcessItems(Process[] processesIn)
        {
            var newItems = new List<ProcessItem>();

            foreach (var p in processesIn)
            {
                newItems.Add(new ProcessItem(p));
            }

            return newItems;
        }

        public void StartNewProcess(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) == false)
                Process.Start(filePath);

            //RefreshProcessList();
        }

        public void CloseProcess(Process processToClose)
        {
            processToClose.Kill();

            //RefreshProcessList();
        }

        public void CloseProcess(int id)
        {
            var processToClose = processItemsCurrent.Where(p => p.Id == id).FirstOrDefault();

            if(processToClose == null)
                return;
            
            processToClose.Kill();

            //RefreshProcessList();
        }

        private bool CheckProcessInList(Process processToCheck)
        {
            bool result = false;

            if(processesCurrent.Contains(processToCheck))
                result = true;

            return result;
        }

        private void AddProcessToList(Process processIn)
        {
            if(CheckProcessInList(processIn))
                return;

            processItemsCurrent.Add(new ProcessItem(processIn));
        } 
        
        private void AddProcessToList(Process[] processesIn)
        {
            //if(CheckProcessInList(processIn))
            //    return;

            foreach (var proc in processesIn)
            {
                processItemsCurrent.Add(new ProcessItem(proc));
            }
        }

        private void AddProcessToListById(int id)
        {
            AddProcessToList(Process.GetProcessById(id));
        }

        private void DeleteProcessFromList(Process[] processesToDelete)
        {
            var deleteIds = processesToDelete.Select(p => p.Id);

            foreach (var id in deleteIds)
            {
                DeleteProcessFromListById(id);
            }
        }

        private void DeleteProcessFromList(List<ProcessItem> itemsToDelete)
        {
            var deleteIds = itemsToDelete.Select(p => p.Id);

            foreach (var id in deleteIds)
            {
                DeleteProcessFromListById(id);
            }
        }

        private void DeleteProcessFromListById(int id)
        {
            var item = processItemsCurrent.Where(p => p.Id == id).First();
            if (item != null)
                _ = processItemsCurrent.Remove(item);
        }

        public bool RefreshProcessList()
        {
            var processesIdInList =  processItemsCurrent.Select(p => p.Id);
            var currentProcessesId = processesCurrent.Select(p => p.Id);

            if(CheckProcessesById(processesIdInList, currentProcessesId))
                return false; // no need to refresh

            var processesToDeleteFromList = processesIdInList.Except(currentProcessesId).ToArray();

            foreach (var id in processesToDeleteFromList)
            {
                DeleteProcessFromListById(id);
            }

            var processesToAddToList = currentProcessesId.Except(processesIdInList);

            foreach (var id in processesToDeleteFromList)
            {
                AddProcessToListById(id);
            }

            return true; // resfresh done
        }

        public bool CheckProcessesById(IEnumerable<int> processesInList, IEnumerable<int> processesCurrent)
        {
            return processesInList.Equals(processesCurrent);
        }
    }
}
