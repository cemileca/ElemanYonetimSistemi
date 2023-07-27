using ElemanYonetimSistemi.Business.Interfaces;
using ElemanYonetimSistemi.Domain.Entities.Common;
using ElemanYonetimSistemi.Persistence.Contexts;

namespace ElemanYonetimSistemi.Persistence.Repositories
{
    public class PersonalWriteRepository : WriteRepository<Personal>, IPersonalWriteRepository
    {
        public PersonalWriteRepository(ElemanYonetimSistemiDbContext context) : base(context)
        {
        }
    }
}
