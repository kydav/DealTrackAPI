﻿using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("api/deals")]
    public class DealController : ControllerBase
    {
        private readonly ILogger<DealController> _logger;
        private readonly IDealService _dealService;

        public DealController(ILogger<DealController> logger, IDealService dealService)
        {
            _logger = logger;
            _dealService = dealService;
        }

        [HttpGet("GetAllDeals")]
        public IActionResult GetActiveDeals()
        {

            var dealList = _dealService.GetActiveDeals();
            if (dealList == null)
                return NotFound();
            return Ok(dealList);
        }

        [HttpGet("GetActiveDeals")]
        public IActionResult GetAllDeals()
        {
            var dealList = _dealService.GetAllDeals();
            if (dealList == null)
                return NotFound();
            return Ok(dealList);
        }
            

        [HttpGet("{dealId}", Name = "GetDeal")]
        public IActionResult GetDeal(int dealId)
        {
            var deal = _dealService.GetDeal(dealId);
            if (deal == null)
                return NotFound();
            return Ok(deal);
        }

        [HttpPost]
        public IActionResult CreateDeal(DealDTO deal)
        {
            _dealService.CreateDeal(deal);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateDeal(DealDTO deal)
        {
            _dealService.UpdateDeal(deal);
            return NoContent();
        }

        [HttpDelete("{dealId}")]
        public IActionResult DeleteDeal(int dealId)
        {
            _dealService.DeleteDeal(dealId);
            return NoContent();
        }


    }
    
}
