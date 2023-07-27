using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities.Adresses
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }
        public Country Country { get; set; }
        public ICollection<District> Districts { get; set; }

    }
}
