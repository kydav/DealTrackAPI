using System;
namespace DealTrackAPI.Models
{
    public class PropertyDTO
    {
        public int Id { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
    }
}
