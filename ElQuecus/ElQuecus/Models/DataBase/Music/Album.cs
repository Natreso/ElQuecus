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
        public int albumID { get; set; }

        public string albumName { get; set; }

        public string albumTrack { get; set; }
    }
}
