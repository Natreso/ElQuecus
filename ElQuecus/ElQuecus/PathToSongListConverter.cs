using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ElQuecus.Models;
using TagLib;

namespace ElQuecus
{
    internal static class PathToSongListConverter
    {
        public static async Task<List<Song>> GetFiles(string path) => 
            (from file in (await FileSearch.GetFilePaths(path))
             let tags = File.Create(file)
             where Math.Abs(tags.Properties.Duration.TotalSeconds) > 0
             select new Song(tags.Tag.FirstPerformer ?? file.Split('\\').Last().Split('.')[1],
                 tags.Tag.Title,
                 $"{tags.Properties.Duration.Minutes + ":" + tags.Properties.Duration.Seconds}",
                 tags.Tag.Album, file)).ToList();


        public static Song GetFile(string path)
    {
        var tags = File.Create(path);
        if (tags.Tag.Title == null
            && Math.Abs(tags.Properties.Duration.TotalSeconds) <= 0)
            return null;
        var song = new Song(tags.Tag.FirstPerformer ?? path.Split('\\').Last().Split('.')[1],
            tags.Tag.Title,
            $"{tags.Properties.Duration.Minutes + ":" + tags.Properties.Duration.Seconds}",
            tags.Tag.Album,
            path);
            return song;
    }
        
    }
}
