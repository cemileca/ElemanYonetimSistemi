using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.Business.Interfaces
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddSingleAsync(T model);
        Task<bool> AddRangeAsync(HashSet<T> datas);
        bool Update(T model);
        Task<bool> UpdateByIdAsync(string Id);
        bool UpdateRange(HashSet<T> datas);
        bool Remove(T model);
        Task<bool>RemoveByIdAsync(string Id);
        bool RemoveRange(HashSet<T> datas);
        Task<int> SaveChangesAsync();

    }
}
