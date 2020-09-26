using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealTrackAPI.Entities
{
    public class User
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

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public Guid UserGuid { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }

        [MaxLength(50)]
        public string MobileNumber { get; set; }

        //public Deal Deal { get; set; }

        public virtual Deal CreatedDeal { get; set; }

        public virtual Deal AssignedDeal { get; set; }

        public Comment CreatedComment { get; set; }
    }
}
