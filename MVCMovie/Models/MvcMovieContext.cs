using System;
using Microsoft.EntityFrameworkCore;

namespace MVCMovie.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options ) : base(options)
        {
            
        }

        public DbSet<MVCMovie.Models.Movie> Movie { get; set; }

    }
}
