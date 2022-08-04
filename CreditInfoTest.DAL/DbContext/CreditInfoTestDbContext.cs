using CreditInfoTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CreditInfoTest.DAL.DbContext
{
    public class CreditInfoTestDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CreditInfoTestDbContext(DbContextOptions<CreditInfoTestDbContext> options) : base(options)
        {

        }

        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CreditInfoTestDbContext).Assembly);
        }
    }
}
