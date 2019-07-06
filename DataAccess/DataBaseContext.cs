using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) :
           base(options)
        {
        }

        public DbSet<Claim> Claims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Blogging;Trusted_Connection=True;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Claim>().HasKey(p => p.ClaimIdenfier);
            modelBuilder.Entity<Claim>().Property(p => p.PolicyYear).IsRequired();
            modelBuilder.Entity<Claim>().Property(p => p.ClaimNo).IsRequired();
            modelBuilder.Entity<Claim>().Property(p => p.Memo).HasMaxLength(100);
            modelBuilder.Entity<Claim>().Property(p => p.RowVersion).IsRowVersion();

            modelBuilder.Entity<ClaimType>().Property(p => p.ClaimTypeID).ValueGeneratedNever();

            modelBuilder.Entity<ClaimType>().HasData
                (
                new ClaimType { ClaimTypeID = 1, ClaimTypeName = "P&I" },
                new ClaimType { ClaimTypeID = 2, ClaimTypeName = "FDD" },
                new ClaimType { ClaimTypeID = 3, ClaimTypeName = "Loss Prevention" },
                 new ClaimType { ClaimTypeID = 4, ClaimTypeName = "War" }
                );
        }
    }
}
