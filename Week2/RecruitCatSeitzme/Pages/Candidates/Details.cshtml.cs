using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatSeitzme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSeitzme.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSeitzmeDbContext _context;

        public DetailsModel(RecruitCatSeitzmeDbContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .Include(c => c.Industry)
                .Include(c => c.Company)
                .FirstOrDefaultAsync(m => m.CandidateId == id);

            if (candidate is not null)
            {
                Candidate = candidate;

                return Page();
            }

            return NotFound();
        }
    }
}
