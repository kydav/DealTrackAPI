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
        public int Status { get; set; }

        //[Required]
        //public int PropertyId { get; set; }

        //public ICollection<Property> Property { get; set; }
        //[ForeignKey("Property")]
        public int PropertyId { get; set; }
        public Property DealProperty { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        //[Required]
        //public int LenderId { get; set; }
        //public ICollection<Lender> Lender { get; set; }

        //[Required]
        //public int CreatorId { get; set; }
        //public ICollection<User> Creator { get; set; }

        //public int AssigneeId { get; set; }
        //public ICollection<User> Assignee { get; set; }

        //[ForeignKey("Lender")]
        public int LenderID { get; set; }
        public virtual Lender DealLender { get; set; }

        //[ForeignKey("DealCreator")]
        public int CreatorId { get; set; }
        public virtual User DealCreator { get; set; }

        //[ForeignKey("DealAssignee")]
        public int AssigneeId { get; set; }
        public virtual User DealAssignee { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime AppraisalDate { get; set; }

        public DateTime InspectionDate { get; set; }

        public virtual IList<CustomerDeal> CustomerDeals { get; set; }

        public DateTime ClosingDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
