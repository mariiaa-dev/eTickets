using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces;

namespace eTickets.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository) => _movieRepository = movieRepository;

        public Task<List<Movie>> GetMoviesListAsync(CancellationToken cancellationToken)
        {
            return _movieRepository.GetMoviesListAsync(cancellationToken);
        }
    }
}
