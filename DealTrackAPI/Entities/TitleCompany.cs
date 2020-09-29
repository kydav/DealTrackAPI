using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealTrackAPI.Entities
{
    public class TitleCompany
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string AddressOne { get; set; }

        [MaxLength(50)]
        public string AddressTwo { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        public string State { get; set; }

        [Required]
        [MaxLength(5)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string OfficeNumber { get; set; }

        [MaxLength(50)]
        public string FaxNumber { get; set; }

        //public Deal Deal { get; set; }
    }
}
