using System;
using DealTrackAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DealTrackAPI.Models
{
    public class DealTrackDBContext : DbContext
    {
        //https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(AppContext.;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<CustomerToDeal> CustomersToDeals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerToDeal>()
                .HasKey(x => new { x.CustomerId, x.DealId });

        }
    }
}
