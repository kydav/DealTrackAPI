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
        public PropertyDTO DealProperty { get; set; }
        public LenderDTO DealLender { get; set; }
        public AppraiserDTO DealAppraiser { get; set; }
        public TitleCompanyDTO DealTitleCompany { get; set; }
        public UserDTO DealCreator { get; set; }
        public UserDTO DealAssignee { get; set; }
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
