using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
            List<ListViewItem> result = new List<ListViewItem>();

            var allDrives = DriveInfo.GetDrives();

            foreach (var d in allDrives)
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
