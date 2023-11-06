using AutoMapper;
using eTickets.entities;
using eTickets.Web.Models.Producer;

namespace eTickets.Web.AutoMapper
{
    public class ProducerAutoMapperProfile : Profile
    {
        public ProducerAutoMapperProfile()
        {
            CreateMap<Producer, ProducerViewModel>().ReverseMap();
            CreateMap<Producer, ProducerDetailViewModel>();
        }
    }
}
