using ElemanYonetimSistemi.Domain.Entities.Common;
using ElemanYonetimSistemi.Domain.Entities.Employee;

namespace ElemanYonetimSistemi.Domain.Entities.Partner
{
    public class Partner:BaseEntity
    {
        public Personal Personal { get; set; } //  Ortağın kişisel verileri Adı Soyadı Felan
        public decimal PartnerPercent { get; set; } // % Yüzde kaç ortaktır
        public decimal? PartnerSalary { get; set; } // Eğer Aktif iş gücü olarak çaşılacaksa aylık maaşı (eleman gibi)
        public ICollection<Job>? Jobs { get; set; } // Eğer şirkette aktif iş yapoacaksa hangi işlerin takibinden sorumlu olucak?
        public ICollection<Departman>? Departman{ get; set; } // Eğer iş yapacaksa Hangi Departmanla ilgileneceğini belirtmek için
    }
}
