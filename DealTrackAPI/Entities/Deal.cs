using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealTrackAPI.Entities
{
    public class Deal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int PropertyId { get; set; }
        public ICollection<Property> Property { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public int LenderId { get; set; }
        public ICollection<Lender> Lender { get; set; }
        [Required]
        public int CreatorId { get; set; }
        public ICollection<User> Creator { get; set; }
        public int AssigneeId { get; set; }
        public ICollection<User> Assignee { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<CustomerDeal> Customers { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public DateTime ClosingDate { get; set; }
    }
}
