using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealTrackAPI.Entities
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int DealId { get; set; }
        public Deal Deal { get; set; }

        [Required]
        public int CreatorId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Content { get; set; }
    }
}
