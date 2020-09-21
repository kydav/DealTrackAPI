using System;
using System.Collections.Generic;

namespace DealTrackAPI.Entities
{
    public class Deal
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public string PropertyAddressOne { get; set; }
        public string PropertyAddressTwo { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyZipCode { get; set; }
        public string PropertyState { get; set; }
        public string Description { get; set; }
        public ICollection<Lender> Lender { get; set; }
        public ICollection<User> Creator { get; set; }
        public ICollection<User> Assignee { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<CustomerDeal> Customers { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
