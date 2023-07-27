using ElemanYonetimSistemi.Domain.Entities;
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
        public DbSet<Category> Categories { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow,
                    _ => data.Entity.DeletedDate = DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}