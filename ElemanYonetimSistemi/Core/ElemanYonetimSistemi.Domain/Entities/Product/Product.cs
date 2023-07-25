using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public ICollection<Product>? Model { get; set; }
        public Category ProductCategory { get; set; }
    }
}
