using ElemanYonetimSistemi.Domain.Entities.Adresses;

namespace ElemanYonetimSistemi.Domain.Entities.Common
{
    public class Personal : BaseEntity
    {
        public string IndividualNo { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string? PhotoUrl { get; set; }
        public ICollection<FullAdress>? FullAdresses { get; set; }

    }
}
