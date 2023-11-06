using AutoMapper;
using eTickets.entities;
using eTickets.Web.Models.Cinema;

namespace eTickets.Web.AutoMapper
{
    public class CinemaAutoMapperProfile : Profile
    {
        public CinemaAutoMapperProfile()
        {
            CreateMap<Cinema, CinemaViewModel>().ReverseMap();
            CreateMap<Cinema, CinemaDetailViewModel>();
        }
    }
}
