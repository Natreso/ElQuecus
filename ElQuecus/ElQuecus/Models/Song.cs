using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ElQuecus.Models
{
  
    internal class Song
    {
        public string ArtistName { get; set; }

        public string SongName { get; set; }

        public string Album { get; set; }

        public int Year { get; set; }

        public int Length { get; set; }

        public Song(string artistName, string songName, int length)
        {
            ArtistName = artistName;
            SongName = songName;
            Length = length;
        }
    }
}
