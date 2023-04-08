using eTickets.Domains.Models;
using System.ComponentModel.DataAnnotations;

namespace eTickets.ViewModel
{
    public class CinemaViewModel
    {
        [Display(Name = "Cinema Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }
    }
}
