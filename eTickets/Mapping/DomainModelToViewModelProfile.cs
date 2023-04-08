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
        }
    }
}
