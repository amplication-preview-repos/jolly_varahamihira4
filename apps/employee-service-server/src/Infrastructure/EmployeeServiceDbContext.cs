using EmployeeService.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeService.Infrastructure;

public class EmployeeServiceDbContext : DbContext
{
    public EmployeeServiceDbContext(DbContextOptions<EmployeeServiceDbContext> options)
        : base(options) { }

    public DbSet<EmployeeDbModel> Employees { get; set; }
}
