using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class Employee : BaseEntity
    {
        public Personal Personal { get; set; } // Elemanın kişisel Verileri Adı soyadı Doğum Tarihi Adresi felan
        public decimal ScoreOfEmployee { get; set; } // Elemanın iş gücü puanlaması, yani kalitesi
        public decimal Salary { get; set; }
        public Departman? Departman { get; set; }
        public ICollection<Job> Jobs { get; set; }

        // İlave verilen Görevler. Sorumluluklar. Bu sebepden Puanlama yapılacak
        public ICollection<Tasks> EmployeesTasks { get; set; }

        // Elemanın Mola hakkları mesela: Öğlen Yemeği, Yıllık İzni, İş Çıkışı , Beş  saati vsvsvs
        public ICollection<BreakTime> BreakTimes { get; set; }
        public DateTime StartOfWork { get; set; } //İşe Başlama Tarihi
        public DateTime EndOfWork { get; set; } // İşten Çıkma Tarihi


    }
}
