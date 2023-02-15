using eTickets.Domains.Models;

namespace eTickets.Persistence.Repository.Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetMoviesListAsync(CancellationToken cancellationToken);
    }
}
