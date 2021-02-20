using EFAutoObjToSql.Model;
using Microsoft.EntityFrameworkCore;

namespace EFAutoObjToSql.DbContext
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