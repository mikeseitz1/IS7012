using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSeitzme.Models;

namespace RecruitCatSeitzme.Pages_Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSeitzmeDbContext _context;

        public DetailsModel(RecruitCatSeitzmeDbContext context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Company.FirstOrDefaultAsync(m => m.CompanyId == id);

            if (company is not null)
            {
                Company = company;

                return Page();
            }

            return NotFound();
        }
    }
}
