using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class BreakTime:BaseEntity
    {
        public string BreakName { get; set; } // Mola vaktinin adı Mesela: Öğlen Yemeği, 5 Saati vsvs
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
