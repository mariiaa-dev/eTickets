using eTickets.Application.Context;
using eTickets.Domains.Models;

namespace eTickets.Initializer.Initializer
{
    public class DbInitializer
    {
        private readonly IAppDbContext _context;
        public DbInitializer(IAppDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (!_context.Cinemas.Any())
                _context.Cinemas.AddRange(Seed<Cinema>());
            if (!_context.Actors.Any())
                _context.Cinemas.AddRange(Seed<Actor>());
            if (!_context.Producers.Any())
                _context.Cinemas.AddRange(Seed<Producer>());
            if (!_context.Movies.Any())
                _context.Cinemas.AddRange(Seed<Movie>());
            if (!_context.ActorMovies.Any())
                _context.Cinemas.AddRange(Seed<ActorMovie>());
        }
    }
}
