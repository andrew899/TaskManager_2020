using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Drives
{
    public class DrivesManager
    {
        private DriveInfo[] driveInfos => DriveInfo.GetDrives();

        private List<DriveItem> driveItems = new List<DriveItem>();
        public List<DriveItem> DriveItems => driveItems;

        public DrivesManager()
        {
            foreach (var item in driveInfos)
            {
                driveItems.Add(new DriveItem(item));
            }
        }
    }
}
