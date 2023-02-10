using eTickets.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Application.Context
{
    public interface IAppDbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
