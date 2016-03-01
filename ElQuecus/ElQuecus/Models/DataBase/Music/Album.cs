using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElQuecus.Models.DataBase
{
    class Album
    {
        [Key]
        public int AlbumId { get; set; }

        public string AlbumName { get; set; }

        public string AlbumTrack { get; set; }
    }
}
