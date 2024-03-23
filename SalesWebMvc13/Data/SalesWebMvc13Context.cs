using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc13.Models;

namespace SalesWebMvc13.Data
{
    public class SalesWebMvc13Context : DbContext
    {
        public SalesWebMvc13Context (DbContextOptions<SalesWebMvc13Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
