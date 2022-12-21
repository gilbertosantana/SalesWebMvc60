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

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
