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
    public class LendServise: ILendServise
    {
        private readonly ILendRepository _lendRepository;
        public LendServise(ILendRepository lendRepository)
        {
            _lendRepository = lendRepository;
        }
        public List<Lend> GetLend()
        {
            return _lendRepository.GetAlllLend();
        }
    }
}
