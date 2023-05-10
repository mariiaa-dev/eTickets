using eTickets.Domains.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Domains.Models
{
    public class Producer : MovieParticipant
    {
        //Relationships
        public IList<Movie>? Movies { get; set; }
    }
}
