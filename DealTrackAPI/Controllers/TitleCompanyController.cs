using System;
using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("api/titleCompanies")]
    public class TitleCompanyController : ControllerBase
    {
        private ITitleCompanyService _titleCompanyService;
        private ILogger _logger;

        public TitleCompanyController(ITitleCompanyService titleCompanyService, ILogger logger)
        {
            _titleCompanyService = titleCompanyService;
            _logger = logger;
        }
        [HttpGet("GetAllTitleCompanies")]
        public IActionResult GetAllTitleCompanies()
        {
            try
            {
                var titleCompanyList = _titleCompanyService.GetTitleCompanies();
                if (titleCompanyList == null)
                    return NotFound();
                return Ok(titleCompanyList);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetTitleCompany(int titleCompanyId)
        {
            try
            {
                var titleCompany = _titleCompanyService.GetTitleCompany(titleCompanyId);
                if (titleCompany == null)
                    return NotFound();
                return Ok(titleCompany);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CreateTitleCompany(TitleCompanyDTO titleCompany)
        {
            try
            {
                _titleCompanyService.CreateTitleCompany(titleCompany);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPatch]
        public IActionResult UpdateTitleCompany(TitleCompanyDTO titleCompany)
        {
            try
            {
                _titleCompanyService.UpdateTitleCompany(titleCompany);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult DeleteTitleCompany(int titleCompanyId)
        {
            try
            {
                _titleCompanyService.DeleteTitleCompany(titleCompanyId);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
