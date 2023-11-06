using AutoMapper;
using eTickets.entities;
using eTickets.Web.Models.Actor;

namespace eTickets.Web.AutoMapper
{
    public class ActorAutoMapperProfile : Profile
    {
        public ActorAutoMapperProfile()
        {
            CreateMap<Actor,ActorDetailViewModel>().ReverseMap();
            CreateMap<Actor,ActorViewModel>().ReverseMap();   
        }
    }
}
