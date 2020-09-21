using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealTrackAPI.Entities
{
    public class CustomerDeal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
       
        [Required]
        public int DealId { get; set; }

        public Deal Deal { get; set; }

        [Required]
        public bool IsOurcustomer { get; set; }

        [Required]
        public int CustomerType { get; set; }
    }
}
