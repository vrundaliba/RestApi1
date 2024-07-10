using CustomerAPI.Interfaces;

namespace CustomerAPI.Models
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepo.GetAllCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            var customers = _customerRepo.GetAllCustomers();
            return customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
