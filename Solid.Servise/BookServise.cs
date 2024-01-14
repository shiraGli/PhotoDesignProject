using Solid.Core.Entities;
using Solid.Core.Repository;
using Solid.Core.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servise
{
    public class BookServise: IBookServise
    {
        private readonly IBookRepository _bookRepository;
        public BookServise(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<Book> GetBook()
        {
            return _bookRepository.GetAlllBook();
        }
    }
}
