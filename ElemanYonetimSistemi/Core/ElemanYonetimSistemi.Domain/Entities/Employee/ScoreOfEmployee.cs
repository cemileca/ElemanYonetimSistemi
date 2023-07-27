using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class ScoreOfEmployee : BaseEntity
    {
        // Elemanın verilen göreve yaptığı gayretine verile Puan
        public int ToDoScore { get; set; }

        //Elemana hangi tarihte puanlama verildi
        public DateTime ScoreDate { get; set; }
        // Hangi görevden bu puanı aldıysa onu belirtmek için
        public ICollection<Job>? FromJob { get; set; }

        // Hangi verilern geçici görevden puan aldıysa onu belirtmek için. 
        public ICollection<Tasks>? FomTask { get; set; }
        public ICollection<Employee> Employees { get; set; } // Hangi Eleman bu puanı aldı

    }
}
