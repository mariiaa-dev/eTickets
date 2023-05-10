using AutoMapper;
using eTickets.Domains.Models;
using eTickets.ViewModel;

namespace eTickets.Mapping
{
    public class ViewModelToDomainModelProfile : Profile
    {
        public ViewModelToDomainModelProfile()
        {
            CreateMap<ActorViewModel, Actor>();
            CreateMap<ActorWithIdViewModel, Actor>();
        }
    }
}
