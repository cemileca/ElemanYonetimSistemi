using ElemanYonetimSistemi.Business.Interfaces;
using ElemanYonetimSistemi.Domain.Entities;
using ElemanYonetimSistemi.Persistence.Contexts;

namespace ElemanYonetimSistemi.Persistence.Repositories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoriWriteRepository
    {
        public CategoryWriteRepository(ElemanYonetimSistemiDbContext context) : base(context)
        {
        }
    }
}
