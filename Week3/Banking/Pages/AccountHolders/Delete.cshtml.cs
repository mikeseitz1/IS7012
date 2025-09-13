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
    public class DeleteModel : PageModel
    {
        private readonly Banking.Data.BankingContext _context;

        public DeleteModel(Banking.Data.BankingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolder.FindAsync(id);
            if (accountholder != null)
            {
                AccountHolder = accountholder;
                _context.AccountHolder.Remove(AccountHolder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
