using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext dataContext )
        {
            _context = dataContext;
        }
        public List<Customer> GetAlllCustomer()
        {
           return _context.customers.ToList();
        }
    }
}
