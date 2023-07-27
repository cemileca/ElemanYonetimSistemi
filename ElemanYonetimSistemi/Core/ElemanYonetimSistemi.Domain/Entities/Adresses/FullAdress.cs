using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Adresses
{
    public class FullAdress : BaseEntity
    {
        public string FullAdressName { get; set; } //Home Adress? Work Adress or Other
        public string FullAdressDescrition { get; set; }
        public Country Country { get; set; } // Ülke
        public City City { get; set; } // Şehir
        public District District { get; set; } // İlçe

    }
}
