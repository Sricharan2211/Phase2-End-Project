using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppEms.Models;

namespace WebAppEms.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppEms.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<WebAppEms.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
