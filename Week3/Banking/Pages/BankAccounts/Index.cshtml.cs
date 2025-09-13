using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Banking.Data;
using Banking.Models;

namespace Banking.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly Banking.Data.BankingContext _context;

        public IndexModel(Banking.Data.BankingContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount.ToListAsync();
        }
    }
}
