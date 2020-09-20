using System;
using System.Collections.Generic;

namespace DealTrackAPI.Entities
{
    public class Deal
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public Lender Lender { get; set; }
        public User Creator { get; set; }
        public User Assignee { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<CustomerToDeal> CustomersToDeals { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
