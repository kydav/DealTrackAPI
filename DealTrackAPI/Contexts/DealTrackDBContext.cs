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
            Database.EnsureCreated();
            //migrationBuilder.Sql()
        }
        //https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDeal>()
                .HasKey(x => new { x.CustomerId, x.DealId });

            //modelBuilder.Entity<CustomerDeal>()
            //    .HasOne(d => d.Deal)
            //    .WithMany(d => d.CustomerDeals)
            //    .HasForeignKey(x => x.DealId);

            //modelBuilder.Entity<CustomerDeal>()
            //    .HasOne(d => d.Customer)
            //    .WithMany(d => d.CustomersDeals)
            //    .HasForeignKey(f => f.CustomerId);
            modelBuilder.Entity<Deal>()
                .Property(p => p.EarnestMoney)
                .HasColumnType("decimal(7,2)");

            modelBuilder.Entity<Deal>()
                .HasOne(d => d.DealLender)
                .WithMany()
                .HasPrincipalKey(l => l.Id);

            modelBuilder.Entity<Deal>()
                .HasOne(s => s.DealProperty)
                .WithOne()
                .HasPrincipalKey<Property>(ad => ad.Id);

            modelBuilder.Entity<Deal>()
                .HasOne(s => s.DealAppraiser)
                .WithMany()
                .HasPrincipalKey(ad => ad.Id);

            modelBuilder.Entity<Deal>()
                .HasOne(s => s.DealTitleCompany)
                .WithMany()
                .HasPrincipalKey(ad => ad.Id);

            modelBuilder.Entity<Deal>()
                .HasOne(s => s.DealAssignee)
                .WithMany()
                //.WithOne(s => s.AssignedDeal)
                .HasPrincipalKey(s => s.Id);

            modelBuilder.Entity<Deal>()
                .HasOne(s => s.DealCreator)
                //.WithOne(s => s.CreatedDeal)
                .WithMany()
                .HasPrincipalKey(s => s.Id);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Deal)
                .WithMany(c => c.Comments)
                .HasPrincipalKey(c => c.Id);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Creator)
                .WithMany()
                .HasPrincipalKey(u => u.Id);

            //modelBuilder.Entity<User>()
            //    .HasOne(p => p.CreatedDeal)
            //    .WithOne()
            //    .HasForeignKey<Deal>(p => p.CreatorId);

            //modelBuilder.Entity<User>()
            //    .HasOne(p => p.AssignedDeal)
            //    .WithOne()
            //    .HasForeignKey<Deal>(p => p.AssigneeId);

            //modelBuilder.Entity<Deal>()
            //    .HasMany<Comment>(g => g.Comments)
            //    .WithOne(s => s.Deal)
            //    .HasForeignKey(s => s.DealId);

            modelBuilder.Entity<User>()
                .HasData(
                    new User()
                    {
                        Id = 1,
                        FirstName = "Jennifer",
                        LastName = "Davis",
                        EmailAddress = "realtor1jen@gmail.com",
                        UserName = "jdavis"
                    },
                    new User()
                    {
                        Id = 2,
                        FirstName = "Kyler",
                        LastName = "Davis",
                        EmailAddress = "ky.s.dav@gmail.com",
                        UserName = "kdavis"
                    },
                    new User()
                    {
                        Id = 3,
                        FirstName = "Billy",
                        LastName = "Davis",
                        EmailAddress = "billyandjen@gmail.com",
                        UserName = "bdavis"
                    },
                    new User()
                    {
                        Id = 4,
                        FirstName = "Jessica",
                        LastName = "Davis",
                        EmailAddress = "pokey757@gmail.com",
                        UserName = "jessdavis"
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
                        EmailAddress = "cbearnson@gmail.com",
                        AddressOne = "2167 W 100 N",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-590-9117"
                    },
                    new Customer()
                    {
                        Id = 2,
                        FirstName = "Day",
                        LastName = "Bearnson",
                        EmailAddress = "dbearnson@gmail.com",
                        AddressOne = "2167 W 100 N",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-590-9118"
                    },
                    new Customer()
                    {
                        Id = 3,
                        FirstName = "Jeff",
                        LastName = "Bleazard",
                        EmailAddress = "jbleaz@gmail.com",
                        AddressOne = "617 Cove Drive",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-531-1563"
                    },
                    new Customer()
                    {
                        Id = 4,
                        FirstName = "Mauri",
                        LastName = "Bleazard",
                        EmailAddress = "mbleaz@gmail.com",
                        AddressOne = "617 Cove Drive",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-531-1562"
                    },
                    new Customer()
                    {
                        Id = 5,
                        FirstName = "David",
                        LastName = "Morris",
                        EmailAddress = "ddm@tristate.com",
                        AddressOne = "1340 Parkside Dr",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-559-1996"
                    },
                    new Customer()
                    {
                        Id = 6,
                        FirstName = "Tiffany",
                        LastName = "Morris",
                        EmailAddress = "tiffanyinmaui@gmail.com",
                        AddressOne = "2000 Corporate Drive",
                        City = "Mission Viejo",
                        AddressTwo = "Apt 1014",
                        ZipCode = "92694",
                        State = "CA",
                        MobileNumber = "949-322-8759"
                    },
                    new Customer()
                    {
                        Id = 7,
                        FirstName = "Seller",
                        LastName = "One",
                        EmailAddress = "sellerone@gmail.com",
                        AddressOne = "123 Sales Drive",
                        AddressTwo = "ste 34",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "123-456-7890"
                    },
                    new Customer()
                    {
                        Id = 8,
                        FirstName = "Buyer",
                        LastName = "One",
                        EmailAddress = "buyerone@gmail.com",
                        AddressOne = "123 Buying Drive",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "098-765-4321"
                    },
                    new Customer()
                    {
                        Id = 9,
                        FirstName = "Seller",
                        LastName = "Two",
                        AddressOne = "234 Sales Drive",
                        AddressTwo = "ste 34",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "111-222-3333"
                    },
                    new Customer()
                    {
                        Id = 10,
                        FirstName = "Buyer",
                        LastName = "Two",
                        AddressOne = "234 Buying Drive",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "222-333-4444"
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

            modelBuilder.Entity<Appraiser>()
                .HasData(
                    new Appraiser()
                    {
                        Id = 1,
                        Name = "Karsten Reed",
                        BusinessName = "Utah South Appraisal",
                        EmailAddress = "kreed@utahsouthappraisal.com",
                        AddressOne = "107 N. 200 W.",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        MobileNumber = "435-531-9683",
                        OfficeNumber = "435-865-1921"
                    },
                    new Appraiser()
                    {
                        Id = 2,
                        BusinessName = "Hymas & Associates",
                        EmailAddress = "cody@hymasappraisal.com",
                        AddressOne = "337 S. Main St.",
                        AddressTwo = "Ste 122",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        OfficeNumber = "435-313-1444"
                    }
                );
            modelBuilder.Entity<TitleCompany>()
                .HasData(
                    new TitleCompany()
                    {
                        Id = 1,
                        Name = "Southern Utah Title Company",
                        AddressOne = "210 North 300 West",
                        AddressTwo = "Ste 100",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        FaxNumber = "435-586-5141",
                        OfficeNumber = "435-586-9414"
                    },
                    new TitleCompany()
                    {
                        Id = 2,
                        Name = "First American Title Company",
                        AddressOne = "365 S Main St",
                        City = "Cedar City",
                        ZipCode = "84720",
                        State = "UT",
                        OfficeNumber = "435-586-4476"
                    }
                );
            modelBuilder.Entity<Deal>()
                .HasData(
                    new Deal()
                    {
                        Id = 1,
                        Status = 3,
                        PropertyId = 1,
                        LenderID = 1,
                        AppraiserId = 1,
                        TitleCompanyId = 2,
                        CreatedDate = new DateTime(2020, 7, 15),
                        CreatorId = 1,
                        AssigneeId = 2,
                        EarnestMoney = 1300,
                        InspectionDate = new DateTime(2020, 11, 13),
                        DisclosureDeadline = new DateTime(2020, 11, 14),
                        AppraisalDate = new DateTime(2020, 11, 15),
                        ClosingDate = new DateTime(2020, 11, 30)
                    },
                    new Deal()
                    {
                        Id = 2,
                        Status = 3,
                        PropertyId = 2,
                        LenderID = 2,
                        AppraiserId = 2,
                        TitleCompanyId = 2,
                        CreatedDate = new DateTime(2020, 7, 16),
                        CreatorId = 2,
                        AssigneeId = 3,
                        EarnestMoney = 5000,
                        InspectionDate = new DateTime(2020, 11, 14),
                        AppraisalDate = new DateTime(2020, 11, 16),
                        ClosingDate = new DateTime(2020, 11, 24)
                    },
                    new Deal()
                    {
                        Id = 3,
                        Status = 3,
                        PropertyId = 3,
                        LenderID = 2,
                        AppraiserId = 2,
                        TitleCompanyId = 1,
                        CreatedDate = new DateTime(2020, 7, 18),
                        CreatorId = 4,
                        AssigneeId = 3,
                        EarnestMoney = 2000,
                        InspectionDate = new DateTime(2020, 11, 10),
                        AppraisalDate = new DateTime(2020, 11, 10),
                        ClosingDate = new DateTime(2020, 11, 26)
                    },
                    new Deal()
                    {
                        Id = 4,
                        Status = 3,
                        PropertyId = 4,
                        LenderID = 1,
                        AppraiserId = 1,
                        TitleCompanyId = 1,
                        CreatedDate = new DateTime(2020, 7, 19),
                        CreatorId = 4,
                        AssigneeId = 1,
                        EarnestMoney = 500,
                        InspectionDate = new DateTime(2020, 11, 8),
                        AppraisalDate = new DateTime(2020, 11, 11),
                        ClosingDate = new DateTime(2020, 11, 18)
                    }
                ) ;
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
                        CustomerId = 7,
                        DealId = 1,
                        IsOurcustomer = false,
                        CustomerType = 1
                    },
                    new CustomerDeal()
                    {
                        Id = 4,
                        CustomerId = 8,
                        DealId = 2,
                        IsOurcustomer = false,
                        CustomerType = 0
                    },
                    new CustomerDeal()
                    {
                        Id = 5,
                        CustomerId = 3,
                        DealId = 2,
                        IsOurcustomer = true,
                        CustomerType = 1
                    },
                    new CustomerDeal()
                    {
                        Id = 6,
                        CustomerId = 4,
                        DealId = 2,
                        IsOurcustomer = true,
                        CustomerType = 1
                    },
                    new CustomerDeal()
                    {
                        Id = 7,
                        CustomerId = 5,
                        DealId = 3,
                        IsOurcustomer = true,
                        CustomerType = 0
                    },
                    new CustomerDeal()
                    {
                        Id = 8,
                        CustomerId = 9,
                        DealId = 3,
                        IsOurcustomer = false,
                        CustomerType = 1
                    },
                    new CustomerDeal()
                    {
                        Id = 9,
                        CustomerId = 10,
                        DealId = 4,
                        IsOurcustomer = true,
                        CustomerType = 0
                    },
                    new CustomerDeal()
                    {
                        Id = 10,
                        CustomerId = 6,
                        DealId = 4,
                        IsOurcustomer = true,
                        CustomerType = 1
                    }
                );

            modelBuilder.Entity<Comment>()
                .HasData(
                    new Comment()
                    {
                        Id = 1,
                        Content = "Lorem Ipsum",
                        DealId = 1,
                        CreatedDate = new DateTime(2020, 7, 25),
                        CreatorId = 1
                    },
                    new Comment()
                    {
                        Id = 2,
                        Content = "Lorem Ipsum",
                        DealId = 2,
                        CreatedDate = new DateTime(2020, 8, 13),
                        CreatorId = 1
                    },
                    new Comment()
                    {
                        Id = 3,
                        Content = "Lorem Ipsum",
                        DealId = 2,
                        CreatedDate = new DateTime(2020, 8, 25),
                        CreatorId = 1
                    },
                    new Comment()
                    {
                        Id = 4,
                        Content = "Lorem Ipsum",
                        DealId = 4,
                        CreatedDate = new DateTime(2020, 9, 13),
                        CreatorId = 1
                    }
                );

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<CustomerDeal> CustomerDeals { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Lender> Lenders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

    }
}
