using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class CityRepository: ICityRepository
    {
        private readonly DataContext _context;
        public CityRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<City> GetAlllCity()
        {
            return _context.city.ToList();
        }
    }
}
