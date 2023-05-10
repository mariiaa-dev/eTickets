using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces.Base;

namespace eTickets.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IEntityBaseRepository<Movie> _repository;

        public MovieService(IEntityBaseRepository<Movie> actorRepository) => _repository = actorRepository;
        public Task AddAsync(Movie entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _repository.GetAllListAsync(cancellationToken);
        }

        public Task<Movie?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UpdateAsync(int id, Movie entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
