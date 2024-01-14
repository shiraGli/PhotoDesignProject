using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class LendRepository: ILendRepository
    {
        private readonly DataContext _context;
        public LendRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Lend> GetAlllLend()
        {
            return _context.lend.ToList();
        }
    }
}
