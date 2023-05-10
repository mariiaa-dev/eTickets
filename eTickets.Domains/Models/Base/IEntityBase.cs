using System.ComponentModel.DataAnnotations;

namespace eTickets.Domains.Models.Base
{
    public interface IEntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
