using ElemanYonetimSistemi.Domain.Entities.Employee;
using Microsoft.EntityFrameworkCore;

namespace ElemanYonetimSistemi.Persistence.Databases
{
    public class ElemanYonetimDbContext : DbContext
    {
        public ElemanYonetimDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Employee> Employees { get; set; }
    }
}
