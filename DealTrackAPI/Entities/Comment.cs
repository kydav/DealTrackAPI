using System;
using System.ComponentModel.DataAnnotations;

namespace DealTrackAPI.Entities
{
    public class Comment
    {
        [Required]
        public int Id { get; set; }
        public int DealId { get; set; }
        public Deal Deal { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        public User User { get; set; }

    }
}
