﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetAlllBook();
    }
}
