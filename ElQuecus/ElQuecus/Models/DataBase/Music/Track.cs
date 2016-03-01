using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElQuecus.Models.DataBase
{
    class Track
    {
        [Key]
        public int trackID { get; set; }

        public string trackName { get; set; }
    }
}
