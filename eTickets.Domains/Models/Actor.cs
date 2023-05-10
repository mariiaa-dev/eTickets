using eTickets.Domains.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Domains.Models
{
    public class Actor : MovieParticipant
    {
        //Relationship
        public IList<ActorMovie>? ActorMovies { get; set; }
    }
}
