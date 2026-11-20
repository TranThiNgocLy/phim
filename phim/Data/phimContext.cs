using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using phim.Models;

namespace phim.Data
{
    public class phimContext : DbContext
    {
        public phimContext (DbContextOptions<phimContext> options)
            : base(options)
        {
        }

        public DbSet<phim.Models.genre> genre { get; set; } = default!;
        public DbSet<phim.Models.Movie> Movie { get; set; } = default!;
    }
}
