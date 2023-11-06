using eTickets.entities;
using eTickets.Web.Models.MoviesModels;

namespace eTickets.Web.Models.Cinema
{
    public class CinemaDetailViewModel
    {
        public DateTime Opentime { get; set; }
        public DateTime Closetime { get; set; }
        public string Address { get; set; }
        public CinemaDetailViewModel()
        {
            Movies = new List<MovieViewModel>();
        }
        public List<MovieViewModel> Movies { get; set; }
    }
}
