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
    public class WriterServise: IWriterServise
    {
        private readonly IWriterRepository _writerRepository ;
        public WriterServise(IWriterRepository writerRepository)
        {
            _writerRepository = writerRepository;
        }
        public List<Writer> GetWriter()
        {
            return _writerRepository.GetAlllWriter();
        }
    }
}
