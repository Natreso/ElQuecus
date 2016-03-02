using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ElQuecus.Models;
using TagLib;

namespace ElQuecus
{
    internal static class PathToSongListConverter
    {
        public static async Task<List<Song>> GetFiles(string path)
        {
            return (from file in await FileSearch.GetFilePaths(path)
                let tags = File.Create(file)
                where tags.Tag.FirstPerformer != null && tags.Tag.Title != null
                      && Math.Abs(tags.Properties.Duration.TotalSeconds) > 0
                select
                    new Song(
                        tags.Tag.FirstPerformer,
                        tags.Tag.Title,
                        $"{tags.Properties.Duration.Minutes + ":" + tags.Properties.Duration.Seconds}",
                        tags.Tag.Album,
                        file)).ToList();
        }


        public static Song GetFile(string path)
    {
        var file = File.Create(path);
        if (file.Tag.FirstPerformer == null && file.Tag.Title == null
            && Math.Abs(file.Properties.Duration.TotalSeconds) <= 0)
            return null;
        var song = new Song(file.Tag.FirstPerformer, file.Tag.Title, $"{file.Properties.Duration.Minutes + ":" + file.Properties.Duration.Seconds}", file.Tag.Album, path);
            return song;
    }
        
    }
}
