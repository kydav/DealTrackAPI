using System;
using DealTrackAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace DealTrackAPI.Models
{
    public class DealTrackDBContext : DbContext
    {
        public DealTrackDBContext(DbContextOptions<DealTrackDBContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        //https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDeal>()
                .HasKey(x => new { x.CustomerId, x.DealId });

            modelBuilder.Entity<Lender>()
                .HasData(
                    new Lender()
                    {
                        Id = 1,
                        Name = "Tim Prindle",
                        BusinessName = "MGM Mortgage",
                        EmailAddress = "TPrindle@afncorp.com",
                        AddressOne = "217 N. 300 West",
                        City = "Cedar City",
                        ZipCode = "84721",
                        State = "UT",
                        MobileNumber = "435-531-6796",
                        OfficeNumber = "435-531-6796"
                    },
                    new Lender()
                    {
                        Id = 2,
                        Name = "Karl Hugh",
                        BusinessName = "CityWide Home Loans",
                        EmailAddress = "karl@karlhugh.com",
                        AddressOne = "98 W. Center St.",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-590-1183",
                        OfficeNumber = "435-590-1183"
                    }
                );
            modelBuilder.Entity<Customer>()
                .HasData(
                    new Customer()
                    {
                        Id = 1,
                        FirstName = "Chris",
                        LastName = "Bearnson",
                        AddressOne = "2167 W 100 N",
                        AddressTwo = "apt 1",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-590-9117"
                    },
                    new Customer()
                    {
                        Id = 2,
                        FirstName = "Day",
                        LastName = "Bearnson",
                        AddressOne = "2167 W 100 N",
                        AddressTwo = "apt 1",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-590-9118"
                    },
                    new Customer()
                    {
                        Id = 3,
                        FirstName = "Jeff",
                        LastName = "Bleazard",
                        AddressOne = "617 Cove Drive",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-531-1563"
                    },
                    new Customer()
                    {
                        Id = 4,
                        FirstName = "Mauri",
                        LastName = "Bleazard",
                        AddressOne = "617 Cove Drive",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-531-1562"
                    }
                );
            modelBuilder.Entity<Deal>()
                .HasData(
                    new Deal()
                    {
                        Id = 1,
                        Type = 2,
                        Status = 3,
                        PropertyAddressOne = "60 S 2125 W",
                        PropertyCity = "Cedar City",
                        PropertyState = "UT",
                        PropertyZipCode = "84720",

                    }
                );

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<CustomerDeal> CustomersToDeals { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Lender> Lenders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

    }
}
