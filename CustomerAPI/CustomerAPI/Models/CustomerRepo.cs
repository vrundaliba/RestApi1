using CustomerAPI.Interfaces;

namespace CustomerAPI.Models
{
    public class CustomerRepo : ICustomerRepo
    {
        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>
        {
            new Customer { Id = 1, FirstName = "John", LastName = "Doe" },
            new Customer { Id = 2, FirstName = "Jane", LastName = "Smith" },
            // Add more customers as needed
        };
        }
    }
}
