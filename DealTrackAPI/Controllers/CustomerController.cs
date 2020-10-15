using System;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController
    {
        private readonly ILogger _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService, ILogger logger)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        
    }
}
