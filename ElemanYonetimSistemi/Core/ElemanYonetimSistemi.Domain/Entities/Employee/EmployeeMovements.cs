using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class EmployeeMovements : BaseEntity
    {
        public ICollection<Movements> Movements { get; set; }
        public string? WhyDoThat { get; set; } //Yapma Sebebinin Açıklaması
        public DateTime DoTime { get; set; } // Haraketi Yaptığı  gün saat

    }
}
