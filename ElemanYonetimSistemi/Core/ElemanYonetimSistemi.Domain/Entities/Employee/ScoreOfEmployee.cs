using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class ScoreOfEmployee : BaseEntity
    {
        public int ToDoScore { get; set; } // Elemanın verilen göreve yaptığı gayretine verile Puan
        public ICollection<Job>? FromJob { get; set; } // Hangi görevden bu puanı aldıysa onu belirtmek için
        public ICollection<Employee> Employees { get; set; } // Hangi Eleman bu puanı aldı

    }
}
