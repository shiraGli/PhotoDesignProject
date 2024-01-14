using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface IBook_on_loanServise
    {
        public List<Books_on_loan> GetBooks_on_loan();

    }
}
