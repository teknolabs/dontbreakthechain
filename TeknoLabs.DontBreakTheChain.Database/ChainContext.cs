using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TeknoLabs.DontBreakTheChain.Entities;

namespace TeknoLabs.DontBreakTheChain.DataAccess
{
    public class ChainContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Habit; Trusted_Connection=True;");
        }

        public DbSet<Habit> Habits { get; set; }
    }
}
