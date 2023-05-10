using System.ComponentModel.DataAnnotations;
using eTickets.Domains.Models.Base;

namespace eTickets.Domains.Models.Common
{
    public class MovieParticipant : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        public string? Bio { get; set; }
    }
}
