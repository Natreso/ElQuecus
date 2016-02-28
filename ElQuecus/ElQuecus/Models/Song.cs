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

        public string Title { get; set; }

        public string Album { get; set; }

        public int Year { get; set; }

        public string Length { get; set; }

        public Song(string artistName, string title, string length)
        {
            ArtistName = artistName;
            Title = title;
            Length = length;
        }
    }
}
