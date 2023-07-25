using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class Employee:BaseEntity
    {
        public Personal Personal { get; set; } // Elemanın kişisel Verileri Adı soyadı Doğum Tarihi Adresi felan
        public DateTime StartOfWork { get; set; } //İşe Başlama Tarihi
        public DateTime EndOfWork { get; set; } // İşten Çıkma Tarihi
        public decimal ScoreOfEmployee { get; set; } // Elemanın iş gücü puanlaması, yani kalitesi
        public decimal Salary { get; set; }
        public Departman? Departman { get; set; }
        public ICollection<Job> Jobs { get; set; }

        public ICollection<Task> EmployeesTasks { get; set; } // İlave verilen Görevler. Sorumluluklar. Bu sebepden Puanlama yapılacak


    }
}
