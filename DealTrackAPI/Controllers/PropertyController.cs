using System;
using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("api/properties")]
    public class PropertyController : ControllerBase
    {
        private IPropertyService _propertyService;
        private ILogger _logger;

        public PropertyController(IPropertyService propertyService, ILogger logger)
        {
            _propertyService = propertyService;
            _logger = logger;
        }
        [HttpGet("GetAllProperties")]
        public IActionResult GetAllProperties()
        {
            try
            {
                var propertyList = _propertyService.GetProperties();
                if (propertyList == null)
                    return NotFound();
                return Ok(propertyList);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetProperty(int propertyId)
        {
            try
            {
                var property = _propertyService.GetProperty(propertyId);
                if (property == null)
                    return NotFound();
                return Ok(property);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CreateProperty(PropertyDTO property)
        {
            try
            {
                _propertyService.CreateProperty(property);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPatch]
        public IActionResult UpdateProperty(PropertyDTO property)
        {
            try
            {
                _propertyService.UpdateProperty(property);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult DeleteProperty(int propertyId)
        {
            try
            {
                _propertyService.DeleteProperty(propertyId);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
