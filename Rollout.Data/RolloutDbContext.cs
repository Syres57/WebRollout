using Microsoft.EntityFrameworkCore;
using Rollout.Data.EntityModels;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Rollout.Data
{
    public class RolloutDbContext : DbContext
    {

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Domain> Domain { get; set; }
        public DbSet<Battery> Battery { get; set; }
        public DbSet<StorageLocation> StorageLocation { get; set; }
        public DbSet<WorkStations> WorkStations { get; set; }
        public DbSet<WorkStationState> WorkStationState { get; set; }
        public DbSet<WorkSteps> WorkSteps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Server=DESKTOP-QEG85CB\\SQLEXPRESS;Database=Rollout;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}
