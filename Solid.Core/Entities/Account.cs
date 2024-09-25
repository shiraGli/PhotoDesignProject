﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }

        public Boolean pay { get; set; }
     
        public int Month { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

    }
}
