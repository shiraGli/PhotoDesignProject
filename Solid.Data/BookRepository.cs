using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class BookRepository: IBookRepository
    {
        private readonly DataContext _context;
        public BookRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Book> GetAlllBook()
        {
            return _context.book.ToList();
        }

    }
}
