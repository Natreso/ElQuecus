using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElQuecus.Models
{
    class Song
    {
        private string _artistName;

        public string ArtistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }

        private string _songName;

        public string SongName
        {
            get { return _songName; }
            set { _songName = value; }
        }

        private string _album;

        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }

        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public Song(string ArtistName, string SongName, int Length)
        {
            _artistName = ArtistName;
            _songName = SongName;
            _length = Length;
        }
    }
}
