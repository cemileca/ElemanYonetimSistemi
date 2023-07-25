using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Employee
{
    public class Movements:BaseEntity
    {
        public string MovementsName { get; set; } // Hareket adı Mesela: Erteledi, İptal etti, Kızdı, Görevi Tamamladı.. vsvsvs
        public string? MovementsDescription { get; set;} // Hareket açıklaması
    }
}
