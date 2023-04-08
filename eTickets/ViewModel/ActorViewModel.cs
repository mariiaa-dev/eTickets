using System.ComponentModel.DataAnnotations;

namespace eTickets.ViewModel
{
    public class ActorViewModel
    {
        [Display(Name = "Profile Picture")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        public string? Bio { get; set; }
    }
}
