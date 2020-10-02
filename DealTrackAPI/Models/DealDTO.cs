using System;
using System.Collections.Generic;

namespace DealTrackAPI.Models
{
    public class DealDTO
    {
        public int Id { get; set; }
        //public int Type { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public PropertyDTO Property { get; set; }
        public LenderDTO Lender { get; set; }
        public AppraiserDTO Appraiser { get; set; }
        public TimeoutException TitleCompany { get; set; }
        public UserDTO Creator { get; set; }
        public UserDTO Assignee { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DisclosureDeadline { get; set; }
        public DateTime AppraisalDate { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public List<CustomerDTO> Customers { get; set; }
        public List<CommentDTO> Comments { get; set; }
        public decimal EarnestMoney { get; set; }

    }
}
