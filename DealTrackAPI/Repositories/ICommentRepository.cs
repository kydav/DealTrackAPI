using System;
using System.Collections.Generic;
using DealTrackAPI.Entities;
using DealTrackAPI.Models;

namespace DealTrackAPI.Repositories
{
    public interface ICommentRepository
    {
        public void CreateComment(Comment comment);
        public void DeleteComment(Comment comment);
        public IEnumerable<Comment> GetCommentsForDeal(int dealId);
        public Comment GetComment(int commentId);
        public void UpdateComment(Comment comment);
        public void Save();
    }
}
