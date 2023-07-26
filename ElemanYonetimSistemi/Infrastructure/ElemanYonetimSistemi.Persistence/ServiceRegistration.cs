using ElemanYonetimSistemi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ElemanYonetimSistemi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ElemanYonetimSistemiDbContext>(option=>option.UseNpgsql(Configurations.ConnectionString));
        }
    }
}
