using System;
using System.Collections.Generic;
using DealTrackAPI.Entities;

namespace DealTrackAPI.Repositories
{
    public interface ICustomerRepository
    {
        public Customer GetCustomer(int customerId);
        public List<Customer> GetCustomersForDeal(int dealId);
        public void CreateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
    }
}
