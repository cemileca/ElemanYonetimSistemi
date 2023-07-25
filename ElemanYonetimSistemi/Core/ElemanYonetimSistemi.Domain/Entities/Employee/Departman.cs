using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class Departman : BaseEntity
    {
        public string DepartmanName { get; set; }
        public Departman? DepartmanSenior { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
