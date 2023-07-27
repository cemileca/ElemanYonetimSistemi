using ElemanYonetimSistemi.Business.Interfaces;
using ElemanYonetimSistemi.Domain.Entities.Common;
using ElemanYonetimSistemi.Persistence.Contexts;

namespace ElemanYonetimSistemi.Persistence.Repositories
{
    public class PersonalReadRepository : ReadRepository<Personal>, IPersonalReadRepository
    {
        public PersonalReadRepository(ElemanYonetimSistemiDbContext context) : base(context)
        {
        }
    }
}
