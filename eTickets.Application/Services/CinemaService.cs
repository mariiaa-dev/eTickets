using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces;

namespace eTickets.Application.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly ICinemaRepository _cinemaRepository;

        public CinemaService(ICinemaRepository cinemaRepository) => _cinemaRepository = cinemaRepository;

        public Task<List<Cinema>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _cinemaRepository.GetAllListAsync(cancellationToken);
        }
    }
}
