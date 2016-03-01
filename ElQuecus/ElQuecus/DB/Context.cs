using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElQuecus.Models.DataBase;

namespace ElQuecus.DB
{
    class Context : DbContext
    {
        public Context() : base("ContentDB")
        {

        }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artist { get; set; }

        public DbSet<Track> Tracks { get; set; }
    }
}
