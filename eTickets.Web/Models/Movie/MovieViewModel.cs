using eTickets.Utilities.Enum;
using eTickets.Web.Models.Actor;
using eTickets.Web.Models.Producer;

namespace eTickets.Web.Models.Movie
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public MovieViewModel()
        {
            Actors = new List<ActorViewModel>();
        }


        // Actor relationship - List of objects
        public int ActorIds { get; set; }
        public List<ActorViewModel> Actors { get; set; }


        //producer relationship - Object
        public int ProducerId { get; set; }     
        public ProducerViewModel Producer { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double price { get; set; }
        public MovieCategory Category { get; set; }
    }
}
