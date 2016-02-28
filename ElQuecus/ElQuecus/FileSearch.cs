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
        private static List<string> _filePaths = new List<string>();

        private static string[] _audioExtensions =
        {
            ".mp3", ".flac"
        };

        public static async Task<List<string>> GetFilePaths(string path)
        {
            Task t = new Task(() => GetFiles(path));
            t.Start();
            await t;
            return _filePaths;
        }

        private static void GetFiles(string path)
        {
            foreach (var file in Directory.GetFiles(path).Where(file => _audioExtensions.Contains(Path.GetExtension(file))))
            {
                _filePaths.Add(file);
            }
            foreach (var directory in Directory.GetDirectories(path))
            {
                GetFiles(directory);
            }
        }
    }
}