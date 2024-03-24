using Microsoft.EntityFrameworkCore;
using SalesWebMvc13.Data;
using SalesWebMvc13.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc13.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc13Context _context;

        public DepartmentService(SalesWebMvc13Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
