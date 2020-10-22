using System;
using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService, ILogger<CustomerController> logger)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet("GetAllCustomers")]
        public IActionResult GetActiveCustomers()
        {
            try
            {
                var customerList = _customerService.GetActiveCustomers();
                if (customerList == null)
                    return NotFound();
                return Ok(customerList);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("GetCustomersForDeal")]
        public IActionResult GetCustomersForDeal(int dealId)
        {
            try
            {
                var customerList = _customerService.GetCustomersForDeal(dealId);
                if (customerList == null)
                    return NotFound();
                return Ok(customerList);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetCustomer(int customerId)
        {
            try
            { 
                var customer = _customerService.GetCustomer(customerId);
                if (customer == null)
                    return NotFound();
                return Ok(customer);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CreateCustomer(CustomerDTO customer)
        {
            try
            {
                _customerService.CreateCustomer(customer);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPatch]
        public IActionResult UpdateCustomer(CustomerDTO customer)
        {
            try
            {
                _customerService.UpdateCustomer(customer);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(int customerId)
        {
            try
            {
                _customerService.DeleteCustomer(customerId);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
        
    }
}
