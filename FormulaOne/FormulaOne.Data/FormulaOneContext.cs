using FormulaOne.Entities.Entity_Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Data
{
    public class FormulaOneContext : IdentityDbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceResult> RaceResults { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public FormulaOneContext(DbContextOptions<FormulaOneContext> ctx) 
            : base(ctx)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceResult>()
                .HasKey(rr => rr.Id);

            modelBuilder.Entity<RaceResult>()
                .HasOne(rr => rr.Driver)
                .WithMany(d => d.RaceResults)
                .HasForeignKey(rr => rr.DriverId);

            modelBuilder.Entity<RaceResult>()
                .HasOne(rr => rr.Race)
                .WithMany(r => r.RaceResults)
                .HasForeignKey(rr => rr.RaceId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
