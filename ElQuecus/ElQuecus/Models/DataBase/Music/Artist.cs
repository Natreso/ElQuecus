using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ElQuecus.Models.DataBase
{
    class Artist
    {
        [Key]
        public int artistID { get; set; }

        public string artistName { get; set; }

        public string artistAlbum { get; set; }
    }
}
