using eTickets.Domains.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Domains.Models
{
    public class Actor : MovieParticipant
    {
        [Key]
        public int Id { get; set; }

        //Relationship
        public IList<ActorMovie>? ActorMovies { get; set; }
    }
}
