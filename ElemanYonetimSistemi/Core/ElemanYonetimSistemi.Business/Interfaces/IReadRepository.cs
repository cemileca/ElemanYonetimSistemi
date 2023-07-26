using ElemanYonetimSistemi.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ElemanYonetimSistemi.Business.Interfaces
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> model);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> model);
        Task<T> GetByIdAsync(string id);

    }
}
