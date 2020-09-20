using System;
namespace DealTrackAPI.Models
{
    public class DealDTO
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public LenderDTO Lender { get; set; }
        public UserDTO Creator { get; set; }
        public UserDTO Assignee { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
