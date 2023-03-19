using eTickets.Domains.Models;
using eTickets.Persistence.Context;
using eTickets.Persistence.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context) => _context = context;

        public Task<List<Movie>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _context.Movies.Include(c => c.Cinema).ToListAsync(cancellationToken);
        }
    }
}
