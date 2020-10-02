using System;
namespace DealTrackAPI.Models
{
    public class AppraiserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BusinessName { get; set; }
        public string EmailAddress { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string OfficeNumber { get; set; }
        public string MobileNumber { get; set; }
    }
}
