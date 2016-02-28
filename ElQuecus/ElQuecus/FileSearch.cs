using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ElQuecus
{
    public static class FileSearch
    {
        //поле для хранения того что будем возвращать
        private static List<string> FilePaths = new List<string>();

        private static string[] AudioExtensions = new string[]
        {
            ".mp3", ".flac"
        };

        public static async Task<List<string>> GetFilePaths(string path)
        {
            Task t = new Task(() => GetFiles(path));
            t.Start();
            await t;
            return FilePaths;
        }

        private static void GetFiles(string path)
        {
            //берем файл
            foreach (var directory in Directory.GetDirectories(path))
            {
                foreach (var file in Directory.GetFiles(directory))
                {
                    if (AudioExtensions.Contains(Path.GetExtension(file)))
                    FilePaths.Add(file);
                }
                //идём по подпапкам
                GetFiles(directory);

            }
        }
    }
}