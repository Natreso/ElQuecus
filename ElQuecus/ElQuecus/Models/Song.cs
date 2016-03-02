using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace ElQuecus.Models
{
  
    internal class Song
    {
        
        public string Path { get; set; }

        public string ArtistName { get; set; }

        public string Title { get; set; }

        public string Album { get; set; }

        public int Year { get; set; }

        public string Duration { get; set; }

        public Song(string artistName, string title, string duration, string album, string path)
        {
            ArtistName = artistName??"<Unknown>";
            Title = title;
            Duration = duration;
            Album = album??"<Unknown>";
            Path = path;
        }
       

        public bool Equals(Song other)
        {
            return string.Equals(Path, other.Path) && string.Equals(ArtistName, other.ArtistName) && string.Equals(Title, other.Title) && string.Equals(Album, other.Album) && Year == other.Year && string.Equals(Duration, other.Duration);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Path != null ? Path.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (ArtistName != null ? ArtistName.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Album != null ? Album.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Year;
                hashCode = (hashCode*397) ^ (Duration != null ? Duration.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
