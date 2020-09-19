using System;
namespace DealTrackAPI.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public Guid UserGuid { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
    }
}
