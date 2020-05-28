using System.Diagnostics;

namespace TaskManager_2020
{
    public static class RAMPerformance
    {
        static PerformanceCounter ramUsage = new PerformanceCounter("Memory", "% Committed Bytes in Use");

        public static int GetRamUsage => (int)ramUsage.NextValue();
    }
}

