using SalesWebMvc13.Data;
using SalesWebMvc13.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc13.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc13Context _context;

        public DepartmentService(SalesWebMvc13Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
