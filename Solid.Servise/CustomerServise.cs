using Solid.Core.Entities;
using Solid.Core.Repository;
using Solid.Core.Servise;
using Solid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servise
{
   
    public class CustomerServise:ICustomerServise
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerServise(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;   
        }
        public List<Customer> GetCustomer()
        {
            return _customerRepository.GetAlllCustomer();
        }
    }
}
