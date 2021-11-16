using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YimingGu.BudgetTracker.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace YimingGu.BudgetTracker.Infrastructure.Data
{
    public class BudgetTrackerDbContext: DbContext
    {
        // get the connection string into constructor
        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options) : base(options) 
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // specify fluent API rules for your entities
            modelBuilder.Entity<User>(ConfigureUser);
            modelBuilder.Entity<Income>(ConfigureIncome);
            modelBuilder.Entity<Expenditure>(ConfigureExpenditure);
        }

        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.Id);
        }

        private void ConfigureIncome(EntityTypeBuilder<Income> builder)
        {
            builder.ToTable("Income");
            builder.HasKey(i => i.Id);
        }

        private void ConfigureExpenditure(EntityTypeBuilder<Expenditure> builder)
        {
            builder.ToTable("Expenditure");
            builder.HasKey(e => e.Id);
        }


        // entity classes represented as DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
    }
}



