using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFileList.model
{
    public class FileItem
    {
        public string FullPath { get; set; }
        public string FileName { get; set; }

        public FileItem(string fullpath,char separator)
        {
            FullPath=fullpath;
            var adatok=fullpath.Split(separator);
            FileName = adatok.Last();
        }
    }
}
