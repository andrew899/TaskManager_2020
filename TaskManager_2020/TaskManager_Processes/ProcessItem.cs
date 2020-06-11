using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Processes
{
    public class ProcessItem
    {
        private readonly Process process;

        public int Id => process.Id;

        public string ProcessName => process.ProcessName;
        //public DateTime StartTime => process.StartTime;
        public ProcessThreadCollection Threads => process.Threads;
        public long WorkingSet64 => process.WorkingSet64 / (1024*1024);

        public void Kill() => process.Kill();


        private string instanceName = string.Empty;

        private PerformanceCounter processRAMUsage;
        //public double ProcessRAMUsage => processRAMUsage.RawValue/1024.0/1024.0; // Mb
        public Process GetGetProcess()
        {
            return process;
        }

        private PerformanceCounter processCpuUsage;
        //public int ProcessCpuUsage => (int)processCpuUsage.NextValue();
        //public int ProcessCpuUsage => 0;

        public int GetProcessCpuUsage()
        {
            //var instance = GetProcessInstanceName(ProcessId);
            //processCpuUsage = new PerformanceCounter("Process", "% Processor Time", instance, true);

            //processCpuUsage = ProcessCpuCounter.GetPerfCounterForProcessId(ProcessId);

            if(!IsRuning())
                return -1;
                
            
            if (string.IsNullOrEmpty(instanceName))
                processCpuUsage = new PerformanceCounter("Process", "% Processor Time", ProcessName, true);
            else
                processCpuUsage = new PerformanceCounter("Process", "% Processor Time", instanceName, true);

            return (int)processCpuUsage.NextValue();
        }

        public float GetProcessRAMUsage()
        {
            if (!IsRuning())
                return -1;

            if (string.IsNullOrEmpty(instanceName))
                processRAMUsage = new PerformanceCounter("Process", "Working Set - Private", ProcessName, true);
            else
                processRAMUsage = new PerformanceCounter("Process", "Working Set - Private", instanceName, true);

            return processRAMUsage.NextValue();
        }

        public ProcessItem(Process processIn)
        {
            process = processIn;

            //instanceName = ProcessCpuCounter.GetInstanceNameForProcessId(ProcessId);

            //var instance = GetProcessInstanceName(processIn.Id);

            //processCpuUsage = new PerformanceCounter("Process", "% Processor Time", instanceName, true);

            //processRAMUsage = new PerformanceCounter("Process", "Working Set - Private", instanceName, true);
        }

        private bool IsRuning()
        {
            var isRunning = Process.GetProcesses().Select(p => p.Id == Id).First();
            
            return isRunning;
        }

        //private static string GetProcessInstanceName(int pid)
        //{
        //    PerformanceCounterCategory cat = new PerformanceCounterCategory("Process");

        //    string[] instances = cat.GetInstanceNames();
        //    foreach (string instance in instances)
        //    {
        //        using (PerformanceCounter cnt = new PerformanceCounter("Process",
        //             "ID Process", instance, true))
        //        {
        //            int val = (int)cnt.RawValue;
        //            if (val == pid)
        //            {
        //                return instance;
        //            }
        //        }
        //    }
        //    throw new Exception("Could not find performance counter instance name for current process. This is truly strange ...");
        //}
    }
}
