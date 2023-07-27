using ElemanYonetimSistemi.Business.Interfaces;
using ElemanYonetimSistemi.Persistence.Contexts;
using ElemanYonetimSistemi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ElemanYonetimSistemi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ElemanYonetimSistemiDbContext>(option => option.UseNpgsql(Configurations.ConnectionString));
            services.AddScoped<IPersonalReadRepository, PersonalReadRepository>();
            services.AddScoped<IPersonalWriteRepository, PersonalWriteRepository>();
            services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();
            services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoriWriteRepository,CategoryWriteRepository> ();

        }
    }
}
