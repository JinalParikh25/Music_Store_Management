using Music_Store_Management.Models;

namespace Music_Store_Management.Services
{
    public class GetCustomerListServices
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>
            {
                new Customer{ Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams"}
            };
            return customerList;
        }
    }
}
