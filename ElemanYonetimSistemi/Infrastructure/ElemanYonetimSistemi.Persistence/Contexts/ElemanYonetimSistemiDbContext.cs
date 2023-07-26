using ElemanYonetimSistemi.Domain.Entities.Common;
using ElemanYonetimSistemi.Domain.Entities.Employee;
using Microsoft.EntityFrameworkCore;

namespace ElemanYonetimSistemi.Persistence.Contexts
{
    public class ElemanYonetimSistemiDbContext : DbContext
    {
        public ElemanYonetimSistemiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Personal> Personals { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}