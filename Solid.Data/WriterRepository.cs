using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class WriterRepository:IWriterRepository
    {
        private readonly DataContext _context;
        public WriterRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Writer> GetAlllWriter()
        {
            return _context.writer.ToList();
        }
    }
}
