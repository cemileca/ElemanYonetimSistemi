using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Adresses
{
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }
        public string CountryShirtName { get; set; }
        public int ZipCode { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
