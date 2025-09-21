using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BankMe.Data;
using BankMe.Models;

namespace BankMe.Pages.AccountHolders
{
    public class CreateModel : PageModel
    {
        private readonly BankMe.Data.BankMeContext _context;

        public CreateModel(BankMe.Data.BankMeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AccountHolder AccountHolder { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AccountHolder.Add(AccountHolder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
