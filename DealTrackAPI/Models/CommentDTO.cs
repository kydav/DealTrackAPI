using System;
namespace DealTrackAPI.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public DealDTO Deal { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        public UserDTO Creator { get; set; }
    }
}
