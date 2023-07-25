using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Adresses
{
    public class District:BaseEntity
    {
        public string DistrictName { get; set; } //İlçe
        public string DistrictDescription { get; set; }
        public string Quarter { get; set; } //Mahalle
        public City City { get; set; } // Şehir
    }
}
