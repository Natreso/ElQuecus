using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElQuecus.Models.DataBase
{
    class Track
    {
        public int TrackId { get; set; }

        public string TrackName { get; set; }

        //Ссылка на альбом
        public Album Album;
    }
}
