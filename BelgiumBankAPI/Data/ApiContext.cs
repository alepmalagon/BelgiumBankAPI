using Microsoft.EntityFrameworkCore;
using BelgiumBankAPI.Models;

namespace BelgiumBankAPI.Data
{
    public class ApiContext: DbContext
    {
        public DbSet<BankAccount> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options) 
        {

        }
    }
}
