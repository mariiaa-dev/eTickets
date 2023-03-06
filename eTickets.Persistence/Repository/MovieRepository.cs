using eTickets.Domains.Models;
using eTickets.Persistence.Context.Interfaces;
using eTickets.Persistence.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IAppDbContext _context;

        public MovieRepository(IAppDbContext context) => _context = context;

        public Task<List<Movie>> GetMoviesListAsync(CancellationToken cancellationToken)
        {
            return _context.Movies.Include(c => c.Cinema).ToListAsync(cancellationToken);
        }
    }
}
