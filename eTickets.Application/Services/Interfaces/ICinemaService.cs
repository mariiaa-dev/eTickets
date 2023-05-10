using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces.Base;

namespace eTickets.Application.Services.Interfaces
{
    public interface ICinemaService : IEntityBaseRepository<Cinema>
    {
    }
}
