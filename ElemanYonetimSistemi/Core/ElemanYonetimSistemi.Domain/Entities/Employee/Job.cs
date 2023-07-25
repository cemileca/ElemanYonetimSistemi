using ElemanYonetimSistemi.Domain.Entities.Common;
using ElemanYonetimSistemi.Domain.Entities.Employee;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElemanYonetimSistemi.Domain.Entities
{
    public class Job : BaseEntity
    {
        public string JobName { get; set; }
        public string? JobDescription { get; set; }
        public Departman? JobDepartman { get; set; }

    }
}
