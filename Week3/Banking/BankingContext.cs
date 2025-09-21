using Microsoft.EntityFrameworkCore; // Fixes CS0246 for DbSet<>
using Banking.Models; // Replace with the actual namespace containing BankAccount and AccountHolder

public class BankingContext : DbContext // Fixes CS0116 by ensuring members are inside a class
{
    public DbSet<AccountHolder> AccountHolder { get; set; }
    public DbSet<BankAccount> BankAccount { get; set; }
}