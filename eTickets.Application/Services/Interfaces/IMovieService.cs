using eTickets.Domains.Models;

namespace eTickets.Application.Services.Interfaces
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllListAsync(CancellationToken cancellationToken);
    }
}
