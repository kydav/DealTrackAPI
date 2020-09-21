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
            modelBuilder.Entity<User>()
                .HasData(
                    new User()
                    {
                        Id = 1,
                        FirstName = "Jennifer",
                        LastName = "Davis",
                        EmailAddress = "realtor1jen@gmail.com",
                        UserName = "jdavis",

                    },
                    new User()
                    {
                        Id = 2,
                        FirstName = "Kyler",
                        LastName = "Davis",
                        EmailAddress = "ky.s.dav@gmail.com",
                        UserName = "kdavis",

                    },
                    new User()
                    {
                        Id = 3,
                        FirstName = "Billy",
                        LastName = "Davis",
                        EmailAddress = "billyandjen@gmail.com",
                        UserName = "bdavis",

                    },
                    new User()
                    {
                        Id = 4,
                        FirstName = "Jessica",
                        LastName = "Davis",
                        EmailAddress = "pokey757@gmail.com",
                        UserName = "jessdavis",

                    }
                );
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
                    },
                    new Customer()
                    {
                        Id = 5,
                        FirstName = "David",
                        LastName = "Morris",
                        AddressOne = "1340 Parkside Dr",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-559-1996"
                    },
                    new Customer()
                    {
                        Id = 6,
                        FirstName = "Tiffany",
                        LastName = "Morris",
                        AddressOne = "2000 Corporate Drive",
                        AddressTwo = "Apt 1014",
                        ZipCode = "92694",
                        State = "CA",
                        MobileNumber = "949-322-8759"
                    }
                );
            modelBuilder.Entity<Deal>()
                .HasData(
                    new Deal()
                    {
                        Id = 1,
                        Type = 2,
                        Status = 3,
                        PropertyId = 1,
                        CreatedDate = new DateTime(2020, 7, 15),
                        CreatorId = 1,
                        AssigneeId = 1,
                    },
                    new Deal()
                    {
                        Id = 1,
                        Type = 2,
                        Status = 3,
                        PropertyId = 1,
                        CreatedDate = new DateTime(2020, 7, 15),
                        CreatorId = 1,
                        AssigneeId = 1,
                    },
                    new Deal()
                    {
                        Id = 1,
                        Type = 2,
                        Status = 3,
                        PropertyId = 1,
                        CreatedDate = new DateTime(2020, 7, 15),
                        CreatorId = 1,
                        AssigneeId = 1,
                    },
                    new Deal()
                    {
                        Id = 1,
                        Type = 2,
                        Status = 3,
                        PropertyId = 1,
                        CreatedDate = new DateTime(2020, 7, 15),
                        CreatorId = 1,
                        AssigneeId = 1,
                    }
                );
            modelBuilder.Entity<CustomerDeal>()
                .HasData(
                    new CustomerDeal()
                    {
                        Id = 1,
                        CustomerId = 1,
                        DealId = 1,
                        IsOurcustomer = true,
                        CustomerType = 0
                    },
                    new CustomerDeal()
                    {
                        Id = 2,
                        CustomerId = 2,
                        DealId = 1,
                        IsOurcustomer = true,
                        CustomerType = 0
                    },
                    new CustomerDeal()
                    {
                        Id = 3,
                        CustomerId = 0,
                        DealId = 0,
                        IsOurcustomer = true,
                        CustomerType = 0
                    },
                    new CustomerDeal()
                    {
                        Id = 4,
                        CustomerId = 0,
                        DealId = 0,
                        IsOurcustomer = true,
                        CustomerType = 0
                    },
                    new CustomerDeal()
                    {
                        Id = 5,
                        CustomerId = 0,
                        DealId = 0,
                        IsOurcustomer = true,
                        CustomerType = 0
                    }
                );
            modelBuilder.Entity<Property>()
                .HasData(
                    new Property()
                    {
                        Id = 1,
                        AddressOne = "2209 Cedar Hill Dr.",
                        City = "Cedar City",
                        State = "UT",
                        ZipCode = "84720"
                    },
                    new Property()
                    {
                        Id = 2,
                        AddressOne = "2216 Cedar Hill Dr.",
                        City = "Cedar City",
                        State = "UT",
                        ZipCode = "84720"
                    },
                    new Property()
                    {
                        Id = 3,
                        AddressOne = "2239 Cedar Hill Dr.",
                        City = "Cedar City",
                        State = "UT",
                        ZipCode = "84720"
                    },
                    new Property()
                    {
                        Id = 4,
                        AddressOne = "171 College Way",
                        AddressTwo = "#7",
                        City = "Cedar City",
                        State = "UT",
                        ZipCode = "84720"
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
