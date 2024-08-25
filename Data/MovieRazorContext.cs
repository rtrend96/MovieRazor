using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieRazor.Models;

namespace MovieRazor.Data
{
    public class MovieRazorContext : DbContext
    {
        public MovieRazorContext (DbContextOptions<MovieRazorContext> options)
            : base(options)
        {
        }

        public DbSet<MovieRazor.Models.Movie> Movie { get; set; } = default!;
    }
}
