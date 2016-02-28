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
        public static async Task<List<TagLib.File>> GetFiles(string path)
        {
            List<TagLib.File> FileList = new List<File>();

            try
            {
                foreach (var file in await FileSearch.GetFilePaths(path))
                {

                    FileList.Add(File.Create(file));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error processing file: {0}", e);
            }

            return FileList;
        }

        public static List<Song> Converter(List<File> FileList)
        {
            List<Song> TracksList = new List<Song>();
            try
            {
                foreach (var file in FileList)
                {
                    string artist = file.Tag.FirstPerformer;
                    string title = file.Tag.Title;
                    string length = file.Properties.Duration.ToString();

                    Models.Song Track = new Song(artist, title, length);
                }
            }
            catch (Exception)
            {
                
                //ignored
            }

            return TracksList;
        }
    }
}
