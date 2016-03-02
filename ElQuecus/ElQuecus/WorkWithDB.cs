using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElQuecus.DB;
using System.Data.Entity;
using ElQuecus.Models;
using ElQuecus.Models.DataBase;
using System.Data.Entity.Migrations;

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
                    context.Artists.AddOrUpdate(a => a.ArtistName, new Artist
                    {
                        ArtistName = song.ArtistName
                    });
                    context.SaveChanges();
                    context.Albums.AddOrUpdate(a => a.AlbumName,
                        new Album
                        {
                            AlbumName = song.Album,
                            Artist = context.Artists.FirstOrDefault(a => a.ArtistName == song.ArtistName)
                        });
                    context.SaveChanges();
                    context.Tracks.AddOrUpdate(t => t.TrackName, new Track
                    {
                        TrackName = song.Title,
                        Duration = song.Duration,
                        PathOnUserPc = song.Path,
                        Album = context.Albums.FirstOrDefault(a => a.AlbumName == song.Album)
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}