using eTickets.entities;
using eTickets.Web.Models.Producer;
using eTickets.Web.Models.Actor;
using eTickets.Web.Models.Cinema;
namespace eTickets.entities
{
    public class MovieDetailViewModel
    {
        public string ImageURL { get; set; }

        //Relationships 
        public MovieDetailViewModel()
        {
            Actors = new List<ActorViewModel>();

            Theatres = new List<CinemaViewModel>();
        }
        public int ActorIds { get; set; }
        public List<ActorViewModel> Actors { get; set; }

        public int ProducerId { get; set; }
        public ProducerViewModel producer { get; set; }

        public int TheatreIds { get; set; }
        public List<CinemaViewModel> Theatres { get; set; }

    }
}
