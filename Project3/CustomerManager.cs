using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class CustomerManager
    {
        List<Customer> customers;
        public CustomerManager()
        {
            customers = new List<Customer>();
            {
                new Customer { Id = 1, City = "İzmir", Email = "asd@", FirstName = "Fırat", LastName = "A." };
                new Customer { Id = 1, City = "İzmir", Email = "asd@", FirstName = "Boran", LastName = "A." };
                new Customer { Id = 1, City = "Ağrı", Email = "asd@", FirstName = "Fatih", LastName = "B." };
            };
        }
        
        public List<Customer> GetAll()
        {
            return customers;
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
