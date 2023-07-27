using System.ComponentModel.DataAnnotations;

namespace ElemanYonetimSistemi.Domain.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
