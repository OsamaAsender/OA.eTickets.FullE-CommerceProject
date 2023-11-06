using AutoMapper;
using eTickets.entities;
using eTickets.Web.Models.Movie;

namespace eTickets.Web.AutoMapper
{
    public class MovieAutoMapperProfile : Profile
    {
        public MovieAutoMapperProfile()
        {
            CreateMap<Movie, MovieViewModel>().ReverseMap();
            CreateMap<Movie, MovieListViewModel>();
            CreateMap<Movie, MovieDetailViewModel>();
        }
    }
}
