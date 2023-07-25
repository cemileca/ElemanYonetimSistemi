namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class ScoreOfEmployeeCurrentYear
    {
        public decimal ScoreCurrentYear { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public DateTime CurrentYear { get; set; } // Şu anki Yıl Cari Yıl

    }
}
