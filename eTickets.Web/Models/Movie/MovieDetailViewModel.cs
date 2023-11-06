using eTickets.entities;
using eTickets.Web.Models.Producer;
using eTickets.Web.Models.Actor;
using eTickets.Web.Models.Cinema;
namespace eTickets.entities
{
    public class MovieDetailViewModel
    {
        public MovieDetailViewModel()
        {
            Actors = new List<ActorViewModel>();

            Theatres = new List<CinemaViewModel>();
        }
        public List<ActorViewModel> Actors { get; set; }
        public ProducerViewModel producer { get; set; }
        public string ImageURL { get; set; }
        public List<CinemaViewModel> Theatres { get; set; }

    }
}
