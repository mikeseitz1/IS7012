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
    public class IndexModel : PageModel
    {
        private readonly BankMe.Data.BankMeContext _context;

        public IndexModel(BankMe.Data.BankMeContext context)
        {
            _context = context;
        }

        public IList<AccountHolder> AccountHolder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            AccountHolder = await _context.AccountHolder.ToListAsync();
        }
    }
}
