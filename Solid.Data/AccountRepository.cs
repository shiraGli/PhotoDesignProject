using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class AccountRepository: IAccountRepository
    {
        private readonly DataContext _context;
        public AccountRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Account> GetAlllAccount()
        {
            return _context.account.ToList();
        }
    }
}
