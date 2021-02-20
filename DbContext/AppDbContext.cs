using EFSqlLogging.Model;
using Microsoft.EntityFrameworkCore;

namespace EFSqlLogging.DbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions
            <AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}