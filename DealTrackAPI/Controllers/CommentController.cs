using System;
using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("comments")]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<CommentController> _logger;
        private readonly ICommentService _commentService;

        public CommentController(ILogger<CommentController> logger, ICommentService commentService)
        {
            _logger = logger;
            _commentService = commentService;
        }

        [HttpGet("GetCommentsForDeal")]
        public IActionResult GetCommentsForDeal(int dealId)
        {

            var commentList = _commentService.GetCommentsForDeal(dealId);
            if (commentList == null)
                return NotFound();
            return Ok(commentList);
        }

        [HttpPut]
        public IActionResult CreateComment(CommentDTO comment)
        {
            _commentService.CreateComment(comment);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteComment(CommentDTO comment)
        {
            _commentService.DeleteComment(comment);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UdpateComment(CommentDTO comment)
        {
            _commentService.UpdateComment(comment);
            return NoContent();
        }

    }
}
