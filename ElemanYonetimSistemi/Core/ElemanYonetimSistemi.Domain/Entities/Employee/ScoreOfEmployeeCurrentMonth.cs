using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class ScoreOfEmployeeCurrentMonth : BaseEntity
    {
        public int ScoreOfCurrentMonth { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public DateTime CurrentMonth { get; set; } // Şu anki Cari Ay
    }
}
