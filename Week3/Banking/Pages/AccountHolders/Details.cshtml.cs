using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Banking.Data;
using Banking.Models;

namespace Banking.Pages.AccountHolders
{
    public class DetailsModel : PageModel
    {
        private readonly Banking.Data.BankingContext _context;

        public DetailsModel(Banking.Data.BankingContext context)
        {
            _context = context;
        }

        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.AccountHolderId == id);

            if (accountholder is not null)
            {
                AccountHolder = accountholder;

                return Page();
            }

            return NotFound();
        }
    }
}
