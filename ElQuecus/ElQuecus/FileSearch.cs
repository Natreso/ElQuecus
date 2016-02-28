using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ElQuecus
{
    public static class FileSearch
    {
        //поле для хранения того что будем возвращать
        private static List<string> _filePaths = new List<string>();
        private static readonly Regex checkPath = new Regex(@"^[A-Z]+:+\\");
        private static string[] _audioExtensions =
        {
            ".mp3", ".flac"
        };

        public static async Task<List<string>> GetFilePaths(string path)
        {
            if(!checkPath.IsMatch(path)) throw new ArgumentException();
            var t = new Task(() => GetFiles(path));
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

            try
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    GetFiles(directory);
                }
            }
            catch (UnauthorizedAccessException)
            {
                //ignored
            }
        }
    }
}