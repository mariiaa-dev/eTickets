using eTickets.Domains.Models;
using eTickets.Persistence.Context;
using eTickets.Persistence.Repository.Interfaces;
using eTickets.SeedStorage.InitialData;

namespace eTickets.Initializer.Initializer
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public DbInitializer(AppDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public async Task InitializeAsync(CancellationToken cancellationToken)
        {
            if (!_context.Cinemas.Any())
            {
                _context.Cinemas.AddRange(Storage.Seed<Cinema>());
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            if (!_context.Actors.Any())
            {
                _context.Actors.AddRange(Storage.Seed<Actor>());
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            if (!_context.Producers.Any())
            {
                _context.Producers.AddRange(Storage.Seed<Producer>());
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            if (!_context.Movies.Any())
            {
                _context.Movies.AddRange(Storage.Seed<Movie>());
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            if (!_context.ActorMovies.Any())
            {
                _context.ActorMovies.AddRange(Storage.Seed<ActorMovie>());
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
