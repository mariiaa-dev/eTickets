using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces.Base;

namespace eTickets.Application.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly IEntityBaseRepository<Cinema> _repository;

        public CinemaService(IEntityBaseRepository<Cinema> actorRepository) => _repository = actorRepository;

        public Task AddAsync(Cinema entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cinema>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _repository.GetAllListAsync(cancellationToken);
        }

        public Task<Cinema?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Cinema> UpdateAsync(int id, Cinema entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
