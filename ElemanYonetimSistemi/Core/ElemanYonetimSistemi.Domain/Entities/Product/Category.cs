using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string  CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
    }
}
