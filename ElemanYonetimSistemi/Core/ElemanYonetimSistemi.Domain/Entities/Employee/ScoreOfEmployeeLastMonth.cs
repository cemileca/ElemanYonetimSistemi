using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class ScoreOfEmployeeLastMonth
    {
        public Month LastMonth { get; set; }
        public decimal ScoreForMonth { get; set; }
    }
}
