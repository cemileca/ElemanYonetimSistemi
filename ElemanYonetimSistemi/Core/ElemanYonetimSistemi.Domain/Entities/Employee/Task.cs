using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class Task : BaseEntity
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string Respite { get; set; } // Tanınan Süreç, Mühlet. Aciliyet Derecesi
        public Personal TaskAuthorized { get; set; } //Görevi veren kişi
        public ICollection<Personal> Employee { get; set; } // Görevlendirilen Kişi
        public bool IsPublic { get; set; } // bu görev ile görevlendirildiğini her kes görsün mü?
    }
}
