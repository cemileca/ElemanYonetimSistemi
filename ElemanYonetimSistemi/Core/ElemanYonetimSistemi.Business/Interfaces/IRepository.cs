using ElemanYonetimSistemi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ElemanYonetimSistemi.Business.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
