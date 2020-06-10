using System.IO;

namespace TaskManager_Drives
{
    public class DriveItem
    {
        private readonly DriveInfo drive;

        public string Name => drive.Name;
        public string DriveFormat => drive.DriveFormat;
        public string VolumeLabel => drive.VolumeLabel;
        public string DriveType => drive.DriveType.ToString();
        public bool IsReady => drive.IsReady;
        public long AvailableFreeSpace => drive.AvailableFreeSpace;
        public long TotalSize => drive.TotalSize;
        
        public DriveItem(DriveInfo driveIn)
        {
            drive = driveIn;
        }
    }
}