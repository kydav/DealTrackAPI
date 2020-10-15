using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface ICustomerService
    {
        public CustomerDTO GetCustomer(int customerId);
        public List<CustomerDTO> GetCustomersForDeal(int dealId);
        public void CreateCustomer(CustomerDTO customer);
        public void DeleteCustomer(CustomerDTO customer);
        public void UpdateCustomer(CustomerDTO customer);
    }
}
