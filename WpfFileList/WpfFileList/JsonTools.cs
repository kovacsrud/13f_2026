using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WpfFileList.model;

namespace WpfFileList
{
    public static class JsonTools
    {
        public static void ListToJson(string fajl,FileList filelist)
        {
            string json=JsonConvert.SerializeObject(filelist);
            File.WriteAllText(fajl,json);
        }

        public static FileList JsonToList(string fajl)
        {
            FileList filelist = new FileList();
            if (File.Exists(fajl))
            {
                string json=File.ReadAllText(fajl);
                filelist = JsonConvert.DeserializeObject<FileList>(json);
            }


            return filelist;
        }
    }
}
