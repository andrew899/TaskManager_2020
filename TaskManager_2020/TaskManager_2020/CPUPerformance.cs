using System.Diagnostics;

namespace TaskManager_2020
{
    public static class CPUPerformance
    {
        private static PerformanceCounter cpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        public static int GetCPUTatalUsageInPercent => (int)cpuUsage.NextValue();
    }
}
