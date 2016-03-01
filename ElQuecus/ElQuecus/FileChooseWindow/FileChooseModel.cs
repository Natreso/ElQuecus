using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElQuecus.Models;

namespace ElQuecus.FileChooseWindow
{
    internal class FileChooseModel
    {
        public static async Task<List<Song>> GetSongList(string path)
        {
            return await PathToSongListConverter.GetFiles(path);
        } 
    }
}
