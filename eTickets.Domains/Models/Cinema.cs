﻿using eTickets.Domains.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Domains.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        //Relationships
        public IList<Movie>? Movies { get; set; }
    }
}
