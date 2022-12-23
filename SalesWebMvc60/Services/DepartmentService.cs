using Microsoft.EntityFrameworkCore;
using SalesWebMvc60.Data;
using SalesWebMvc60.Models;

namespace SalesWebMvc60.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc60Context _context;

        public DepartmentService(SalesWebMvc60Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}