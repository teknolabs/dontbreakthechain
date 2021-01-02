using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TeknoLabs.Core;
using TeknoLabs.DontBreakTheChain.Entities;

namespace TeknoLabs.DontBreakTheChain.DataAccess
{
    //public class ChainContext : DbContext
    //{

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Habit; Trusted_Connection=True;");
    //    }

    //    public DbSet<Habit> Habits { get; set; }
    //}

    public class ChainContext : IdentityDbContext
    {
        //public ChainContext(DbContextOptions<ChainContext> options)
        //    : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Chain; Trusted_Connection=True;");
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Habit> Habits { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
