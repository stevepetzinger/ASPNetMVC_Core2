using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ComputerStore.Entities;

namespace ComputerStore.DAL.SqlServer
{
    public class ComputerStoreContext : DbContext
    {
        public ComputerStoreContext(DbContextOptions<ComputerStoreContext> options) : base(options) { }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<ComputerType> ComputerTypes { get; set; }
        public DbSet<State> States { get; set; }

        /// <summary>
        /// Create the tables according to specified names
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>().ToTable("Computer");
            modelBuilder.Entity<ComputerType>().ToTable("ComputerTypes");
            modelBuilder.Entity<State>().ToTable("States");
        }
    }
}
