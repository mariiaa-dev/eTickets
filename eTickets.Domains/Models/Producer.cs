using eTickets.Domains.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Domains.Models
{
    public class Producer : MovieParticipant
    {
        [Key]
        public int Id { get; set; }

        //Relationships
        public IList<Movie>? Movies { get; set; }
    }
}
