using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElQuecus.DB;
using System.Data.Entity;
using ElQuecus.Models;
using ElQuecus.Models.DataBase;

namespace ElQuecus
{
    class WorkWithDb
    {
    
        public void LoadToDb(List<Song> list)
        {
            using (Context context = new Context())
            {
                foreach (var song in list)
                {
                    context.Tracks.Add(new Track
                    {
                       TrackName = song.Title                       
                    });
                    context.Artists.Add(new Artist
                    {
                        ArtistName = song.ArtistName
                    });
                    context.Albums.Add(new Album
                    {
                        AlbumName = song.Album
                    });
                    context.SaveChanges(); 
                }
            }
        }

    }
}