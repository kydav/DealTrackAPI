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

            var customerList = _customerService.GetActiveCustomers();
            if (customerList == null)
                return NotFound();
            return Ok(customerList);
        }

        [HttpGet("GetCustomersForDeal")]
        public IActionResult GetCustomersForDeal(int dealId)
        {
            var customerList = _customerService.GetCustomersForDeal(dealId);
            if (customerList == null)
                return NotFound();
            return Ok(customerList);
        }

        [HttpGet]
        public IActionResult GetCustomer(int customerId)
        {
            var customer = _customerService.GetCustomer(customerId);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult CreateCustomer(CustomerDTO customer)
        {
            _customerService.CreateCustomer(customer);
            return NoContent();
        }

        [HttpPatch]
        public IActionResult UpdateCustomer(CustomerDTO customer)
        {
            _customerService.UpdateCustomer(customer);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(int customerId)
        {
            _customerService.DeleteCustomer(customerId);
            return NoContent();
        }
        
    }
}
