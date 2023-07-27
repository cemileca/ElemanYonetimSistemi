using ElemanYonetimSistemi.Domain.Entities.Common;
using ElemanYonetimSistemi.Domain.Entities.Employee;

namespace ElemanYonetimSistemi.Domain.Entities
{
    public class Job : BaseEntity
    {
        public string JobName { get; set; }
        public string? JobDescription { get; set; }
        public Departman? JobDepartman { get; set; }

    }
}
