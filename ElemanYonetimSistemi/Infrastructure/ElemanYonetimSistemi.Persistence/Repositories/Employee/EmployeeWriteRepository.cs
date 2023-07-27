using ElemanYonetimSistemi.Business.Interfaces;
using ElemanYonetimSistemi.Domain.Entities.Employee;
using ElemanYonetimSistemi.Persistence.Contexts;

namespace ElemanYonetimSistemi.Persistence.Repositories
{
    public class EmployeeWriteRepository : WriteRepository<Employee>, IEmployeeWriteRepository
    {
        public EmployeeWriteRepository(ElemanYonetimSistemiDbContext context) : base(context)
        {
        }
    }
}
