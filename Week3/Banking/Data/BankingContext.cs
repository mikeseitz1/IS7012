using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Banking.Models;

namespace Banking.Data
{
    public class BankingContext : DbContext
    {
        public BankingContext (DbContextOptions<BankingContext> options)
            : base(options)
        {
        }

        public DbSet<Banking.Models.AccountHolder> AccountHolder { get; set; } = default!;
        public DbSet<Banking.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
