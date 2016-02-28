using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace ElQuecus
{
    public static class ToTagFile
    {
        public static async Task<List<TagLib.File>> GetFiles(string path)
        {
            List<TagLib.File> FileList = new List<File>();

            foreach (var file in await FileSearch.GetFilePaths(path))
            {
                FileList.Add(File.Create(file));
            }

            return FileList;
        }
    }
}
