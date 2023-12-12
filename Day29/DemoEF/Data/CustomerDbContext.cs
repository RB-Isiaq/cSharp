
using DemoEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoEF.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}