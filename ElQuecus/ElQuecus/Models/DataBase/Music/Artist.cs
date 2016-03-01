﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElQuecus.Models.DataBase
{
    class Artist
    {
        public int ArtistId { get; set; }

        public string ArtistName { get; set; }

        public virtual List<Album> ArtistAlbum { get; set; }
    }
}
