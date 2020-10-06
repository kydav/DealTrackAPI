using System;
using System.Collections.Generic;
using System.Linq;
using DealTrackAPI.Entities;
using DealTrackAPI.Models;

namespace DealTrackAPI.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly DealTrackDBContext _context;

        public CommentRepository(DealTrackDBContext context)
        {
            _context = context;
        }

        public void CreateComment(Comment comment)
        {
            _context.Add(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _context.Comments.Remove(comment);
        }

        public Comment GetComment(int commentId)
        {
            return _context.Comments.Where(c => c.Id == commentId).FirstOrDefault();
        }

        public IEnumerable<Comment> GetCommentsForDeal(int dealId)
        {
            return _context.Comments.Where(cs => cs.DealId == dealId);
        }

        public void UpdateComment(Comment comment)
        {
            _context.Update(comment);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
