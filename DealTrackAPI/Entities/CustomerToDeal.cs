using System;
namespace DealTrackAPI.Entities
{
    public class CustomerDeal
    {
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int DealId { get; set; }

        public Deal Deal { get; set; }

        public bool IsOurcustomer { get; set; }

        public int CustomerType { get; set; }
    }
}
