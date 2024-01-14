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
    public class Book_on_loanServise: IBook_on_loanServise
    {
        private readonly IBook_on_loanRepository _book_on_loanRepository;
        public Book_on_loanServise(IBook_on_loanRepository book_on_loanRepository)
        {
            _book_on_loanRepository = book_on_loanRepository;
        }
        public List<Books_on_loan> GetBooks_on_loan()
        {
            return _book_on_loanRepository.GetAlllBooks_on_loan();
        }
    }
}
