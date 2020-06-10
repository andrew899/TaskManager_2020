using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TaskManager_Drives;

namespace TaskManager_2020
{
    public class DrivesInfo
    {

        private string[] ColumnNames = new string[]
        {
            "Name",
            "Type",
            "Format",
            "Label",
            "Free space",
            "Total space"
        };

        public string[] GetColumnNames => ColumnNames;

        public List<ListViewItem> GetListAllDrives()
        {
            DrivesManager drivesManager = new DrivesManager();

            List<ListViewItem> result = new List<ListViewItem>();

            foreach (var d in drivesManager.DriveItems)
            {
                if (d.IsReady == false)
                    continue;

                var row = new string[]
                {
                    d.Name,
                    d.DriveType.ToString(),
                    d.DriveFormat,
                    d.VolumeLabel,
                    d.AvailableFreeSpace.ToString(),
                    d.TotalSize.ToString()
                };

                ListViewItem listViewItem = new ListViewItem(row);
                listViewItem.Tag = d;

                result.Add(listViewItem);
            }

            return result;
        }
    }
}
