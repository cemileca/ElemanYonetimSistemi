using ElemanYonetimSistemi.Business.Interfaces;
using ElemanYonetimSistemi.Domain.Entities;
using ElemanYonetimSistemi.Persistence.Contexts;

namespace ElemanYonetimSistemi.Persistence.Repositories
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(ElemanYonetimSistemiDbContext context) : base(context)
        {
        }
    }
}
