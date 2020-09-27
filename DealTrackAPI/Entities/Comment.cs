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

        
        public int DealId { get; set; }
        public virtual Deal Deal { get; set; }

        
        public int CreatorId { get; set; }
        public virtual User Creator { get; set;  }

        public DateTime CreatedDate { get; set; }

        public string Content { get; set; }
    }
}
