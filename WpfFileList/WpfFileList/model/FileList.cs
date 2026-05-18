using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfFileList.model
{
    public class FileList
    {
        public ObservableCollection<FileItem> FileItems { get; set; }

        public FileList()
        {
             FileItems = new ObservableCollection<FileItem>();   
        }

        public void SetFileList(string[] files,char separator)
        {
            foreach (var file in files)
            {
                FileItems.Add(new FileItem(file, separator));
            }
        }
    }
}
