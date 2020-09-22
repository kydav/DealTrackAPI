using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealTrackAPI.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string EmailAddress { get; set; }

        [MaxLength(50)]
        public string AddressOne { get; set; }

        [MaxLength(50)]
        public string AddressTwo { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }

        [MaxLength(5)]
        public string ZipCode { get; set; }

        
        [MaxLength(50)]
        public string OfficeNumber { get; set; }

        [MaxLength(50)]
        public string MobileNumber { get; set; }

        public IList<CustomerDeal> CustomersDeals { get; set; }
    }
}
