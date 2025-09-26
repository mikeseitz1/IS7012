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
    public class IndexModel : PageModel
    {
        private readonly AuthenticationApp.Data.ApplicationDbContext _context;

        public IndexModel(AuthenticationApp.Data.ApplicationDbContext context)
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
