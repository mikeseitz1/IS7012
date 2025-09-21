using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankMe.Models;

namespace BankMe.Data
{
    public class BankMeContext : DbContext
    {
        public BankMeContext (DbContextOptions<BankMeContext> options)
            : base(options)
        {
        }

        public DbSet<BankMe.Models.AccountHolder> AccountHolder { get; set; } = default!;
        public DbSet<BankMe.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
