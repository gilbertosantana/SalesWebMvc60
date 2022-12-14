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

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
    }
}
