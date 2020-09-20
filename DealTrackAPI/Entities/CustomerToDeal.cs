using System;
namespace DealTrackAPI.Entities
{
    public class CustomerToDeal
    {
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int DealId { get; set; }

        public Deal Deal { get; set; }
    }
}
