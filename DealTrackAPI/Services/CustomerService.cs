using System;
using System.Collections.Generic;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService()
        {
        }

        public void CreateCustomer(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public CustomerDTO GetCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDTO> GetCustomersForDeal(int dealId)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDTO> GetActiveCustomers()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }
    }
}
