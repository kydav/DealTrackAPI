using System;
using System.Collections.Generic;
using AutoMapper;
using DealTrackAPI.Entities;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public void CreateComment(CommentDTO comment)
        {

            _commentRepository.CreateComment(_mapper.Map<Comment>(comment));
            _commentRepository.Save();
        }

        public void DeleteComment(CommentDTO comment)
        {
            _commentRepository.DeleteComment(_mapper.Map<Comment>(comment));
        }

        public IEnumerable<CommentDTO> GetCommentsForDeal(int dealId)
        {
            var comments = _commentRepository.GetCommentsForDeal(dealId);
            return _mapper.Map<IEnumerable<CommentDTO>>(comments);
        }

        public void UpdateComment(CommentDTO comment)
        {
            _commentRepository.UpdateComment(_mapper.Map<Comment>(comment));
        }
    }
}
