using System;
using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    public class AppraiserController :ControllerBase
    {
        private readonly ILogger<AppraiserController> _logger;
        private readonly IAppraiserService _appraiserService;

        public AppraiserController(ILogger<AppraiserController> logger, IAppraiserService appraiserService)
        {
            _logger = logger;
            _appraiserService = appraiserService;
        }

        [HttpGet]
        public IActionResult GetAppraiser(int appraiserId)
        {
            try
            {
                var appraiser = _appraiserService.GetAppraiser(appraiserId);
                if (appraiser == null)
                    return NotFound();
                return Ok(appraiser);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetAppraisers()
        {
            try
            {
                var appraiserList = _appraiserService.GetAppraisers();
                if (appraiserList == null)
                    return NotFound();
                return Ok(appraiserList);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CreateAppraiser(AppraiserDTO appraiser)
        {
            try
            {
                _appraiserService.CreateAppraiser(appraiser);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPatch]
        public IActionResult UpdateAppraiser(AppraiserDTO appraiser)
        {
            try
            {
                _appraiserService.UpdateAppraiser(appraiser);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult DeleteAppraiser(int appraiserId)
        {
            try
            {
                _appraiserService.DeleteAppraiser(appraiserId);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
