using eTickets.Domains.Models;
using eTickets.Domains.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.ViewModel
{
    public class MovieViewModel
    {
        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }
        public double Price { get; set; }

        [Display(Name = "Image")]
        public string? ImageURL { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public Genre Genre { get; set; }
        public Cinema? Cinema { get; set; }
    }
}
