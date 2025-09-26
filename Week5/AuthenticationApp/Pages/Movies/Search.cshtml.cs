using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AuthenticationApp.Data;
using AuthenticationApp.Models;

namespace AuthenticationApp.Pages.Movies
{
    public class SearchModel : PageModel
    {
        private readonly AuthenticationApp.Data.ApplicationDbContext _context;

        public SearchModel(AuthenticationApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movies { get; set; } = new List<Movie>();
        public bool SearchCompleted { get; set; } = false;
        [BindProperty(SupportsGet = true)]
        public string Query { get; set; }

        public async Task OnGetAsync()
        {
            if (string.IsNullOrWhiteSpace(Query))
            {
                Movies = new List<Movie>();
                SearchCompleted = true;
                return;
            }
            Movies = await _context.Movie
                .Where(m => m.Title.Contains(Query) || m.Genre.Contains(Query))
                .ToListAsync();
            SearchCompleted = true;
        }
    }
}
