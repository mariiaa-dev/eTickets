using eTickets.Domains.Models;
using eTickets.Persistence.ModelTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActorMovieConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
