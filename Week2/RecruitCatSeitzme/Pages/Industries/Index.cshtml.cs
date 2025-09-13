using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSeitzme.Models;

namespace RecruitCatSeitzme.Pages_Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatSeitzmeDbContext _context;

        public IndexModel(RecruitCatSeitzmeDbContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
