using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankMe.Data;
using BankMe.Models;

namespace BankMe.Pages.AccountHolders
{
    public class DetailsModel : PageModel
    {
        private readonly BankMe.Data.BankMeContext _context;

        public DetailsModel(BankMe.Data.BankMeContext context)
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

            var accountholder = await _context.AccountHolder.Include(x => x.BankAccounts).FirstOrDefaultAsync(m => m.AccountHolderId == id);

            if (accountholder is not null)
            {
                AccountHolder = accountholder;

                return Page();
            }

            return NotFound();
        }
    }
}
