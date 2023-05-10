using eTickets.Domains.Models.Base;
using eTickets.Persistence.Context;
using eTickets.Persistence.Repository.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository.Base
{
    internal class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context) => _context = context;

        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await _context.Set<T>().AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id, cancellationToken);

            if (entity == null)
            {
                throw new ArgumentException($"Entity with type '{typeof(T)}' and id={id} not found.");
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<T>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }

        public async Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id, cancellationToken);
        }

        public async Task<T> UpdateAsync(int id, T entity, CancellationToken cancellationToken)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
