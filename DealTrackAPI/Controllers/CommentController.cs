using System;
using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("api/comments")]
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
            try
            {
                var commentList = _commentService.GetCommentsForDeal(dealId);
                if (commentList == null)
                    return NotFound();
                return Ok(commentList);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost(Name = "CreateComment")]
        public IActionResult CreateComment(CommentDTO comment)
        {
            try
            {
                _commentService.CreateComment(comment);
                return NoContent();
                //return CreatedAtRoute();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult DeleteComment(CommentDTO comment)
        {
            try
            {
                _commentService.DeleteComment(comment);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut(Name = "UpdateComment")]
        public IActionResult UpdateComment(CommentDTO comment)
        {
            try
            {
                _commentService.UpdateComment(comment);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
