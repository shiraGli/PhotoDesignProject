using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Customer> customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=shirs_glick_Library_db");
        }

    }

}
