using eTickets.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eTickets.Persistence.ModelTypeConfigurations
{
    internal class ActorMovieConfiguration : IEntityTypeConfiguration<ActorMovie>
    {
        public void Configure(EntityTypeBuilder<ActorMovie> builder)
        {
            builder.HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            builder.HasOne(m => m.Movie)
                .WithMany(am => am.ActorMovies)
                .HasForeignKey(m => m.MovieId);

            builder.HasOne(a => a.Actor)
                .WithMany(am => am.ActorMovies)
                .HasForeignKey(a => a.ActorId);
        }
    }
}
