using eTickets.Domains.Models;
using eTickets.Domains.Models.Base;

namespace eTickets.Persistence.Repository.Interfaces.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<List<T>> GetAllListAsync(CancellationToken cancellationToken);
        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<T> UpdateAsync(int id, T entity, CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
