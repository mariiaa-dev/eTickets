using AutoMapper;
using eTickets.Domains.Models;
using eTickets.ViewModel;

namespace eTickets.Mapping
{
    public class DomainModelToViewModelProfile : Profile
    {
        public DomainModelToViewModelProfile()
        {
            CreateMap<Actor, ActorViewModel>();
            CreateMap<Cinema, CinemaViewModel>();
            CreateMap<Movie, MovieViewModel>();
            CreateMap<Producer, ProducerViewModel>();
        }
    }
}
