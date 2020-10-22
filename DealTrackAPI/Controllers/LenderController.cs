using System;
using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("api/lenders")]
    public class LenderController : ControllerBase
    {
        private ILenderService _lenderService;
        private ILogger _logger;

        public LenderController(ILenderService lenderService, ILogger logger)
        {
            _lenderService = lenderService;
            _logger = logger;
        }
        [HttpGet("GetAllLenders")]
        public IActionResult GetAllLenders()
        {
            try
            {
                var lenderList = _lenderService.GetLenders();
                if (lenderList == null)
                    return NotFound();
                return Ok(lenderList);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetLender(int lenderId)
        {
            try
            {
                var lender = _lenderService.GetLender(lenderId);
                if (lender == null)
                    return NotFound();
                return Ok(lender);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CreateLender(LenderDTO lender)
        {
            try
            {
                _lenderService.CreateLender(lender);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPatch]
        public IActionResult UpdateLender(LenderDTO lender)
        {
            try
            {
                _lenderService.UpdateLender(lender);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult DeleteLender(int lenderId)
        {
            try
            {
                _lenderService.DeleteLender(lenderId);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
