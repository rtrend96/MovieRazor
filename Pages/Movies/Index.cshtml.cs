using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieRazor.Data;
using MovieRazor.Models;

namespace MovieRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieRazor.Data.MovieRazorContext _context;

        public IndexModel(MovieRazor.Data.MovieRazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
