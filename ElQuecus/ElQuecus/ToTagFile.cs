using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElQuecus.Models;
using TagLib;

namespace ElQuecus
{
    internal static class ToTagFile
    {
        public static async Task<List<Song>> GetFiles(string path) => 
            (from file in await FileSearch.GetFilePaths(path)
             let tags = File.Create(file)
             select new Song(tags.Tag.FirstPerformer, tags.Tag.Title, tags.Properties.Duration.ToString(), file)).ToList();
    }
}
