using eTickets.Application.Context;
using eTickets.Domains.Models;
using eTickets.SeedStorage.Storage;

namespace eTickets.Initializer.Initializer
{
    public class DbInitializer
    {
        private readonly IAppDbContext _context;

        public DbInitializer(IAppDbContext context) => _context = context;

        public void Initialize()
        {
            if (!_context.Cinemas.Any())
            {
                _context.Cinemas.AddRange(Storage.Seed<Cinema>());
                _context.SaveChanges();
            }
            if (!_context.Actors.Any())
            {
                _context.Actors.AddRange(Storage.Seed<Actor>());
                _context.SaveChanges();
            }
            if (!_context.Producers.Any())
            {
                _context.Producers.AddRange(Storage.Seed<Producer>());
                _context.SaveChanges();
            }
            if (!_context.Movies.Any())
            {
                _context.Movies.AddRange(Storage.Seed<Movie>());
                _context.SaveChanges();
            }
            if (!_context.ActorMovies.Any())
            {
                _context.ActorMovies.AddRange(Storage.Seed<ActorMovie>());
                _context.SaveChanges();
            }
        }
    }
}
