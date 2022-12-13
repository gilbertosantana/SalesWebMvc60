using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc60.Models;

namespace SalesWebMvc60.Data
{
    public class SalesWebMvc60Context : DbContext
    {
        public SalesWebMvc60Context (DbContextOptions<SalesWebMvc60Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc60.Models.Department> Department { get; set; } = default!;
    }
}
