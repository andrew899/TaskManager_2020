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

        public int ProcessId => process.Id;

        public string ProcessName => process.ProcessName;

        private readonly PerformanceCounter processRAMUsage;
        public long ProcessRAMUsage => processRAMUsage.RawValue;
        public Process GetGetProcess()
        {
            return process;
        }

        private readonly PerformanceCounter processCpuUsage;
        public int ProcessCpuUsage => (int)processCpuUsage.NextValue();
        //public int ProcessCpuUsage => 0;

        public ProcessItem(Process processIn)
        {
            process = processIn;

            //processCpuUsage = ProcessCpuCounter.GetPerfCounterForProcessId(processIn.Id);

            //var instance = GetProcessInstanceName(processIn.Id);

            processCpuUsage = new PerformanceCounter("Process", "% Processor Time", processIn.ProcessName, true);

            processRAMUsage = new PerformanceCounter("Process", "Working Set - Private", processIn.ProcessName, true);
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
