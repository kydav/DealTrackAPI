using System.Collections;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface ICommentService
    {
        public IEnumerable<CommentDTO> GetCommentsForDeal(int dealId);
        public void CreateComment(CommentDTO comment);
        public void DeleteComment(CommentDTO comment);
        public void UpdateComment(CommentDTO comment);
    }
}