using eTickets.Domains.Models;

namespace eTickets.Application.Services.Interfaces
{
    public interface ICinemaService
    {
        Task<List<Cinema>> GetCinemasListAsync(CancellationToken cancellationToken);
    }
}
