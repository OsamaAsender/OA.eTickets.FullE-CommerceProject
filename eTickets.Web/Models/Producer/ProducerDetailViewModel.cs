using eTickets.entities;
using eTickets.Utilities.Enum;
using eTickets.Web.Models.Movie;

namespace eTickets.Web.Models.Producer
{
    public class ProducerDetailViewModel
    {
        public ProducerDetailViewModel()
        {
            Movies = new List<MovieViewModel>();
        }

        //Movie relationship - List of Objects
        public int MoviesIds { get; set; }
        public List<MovieViewModel> Movies { get; set; }

        public string Biography { get; set; }
        public Gender Sex { get; set; }
    }
}
