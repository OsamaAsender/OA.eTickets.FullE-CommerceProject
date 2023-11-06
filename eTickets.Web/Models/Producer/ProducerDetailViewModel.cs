using eTickets.entities;
using eTickets.Web.Models.MoviesModels;

namespace eTickets.Web.Models.Producer
{
    public class ProducerDetailViewModel
    {
        public ProducerDetailViewModel()
        {
            Movies = new List<MovieViewModel>();
        }
        public List<MovieViewModel> Movies { get; set; }
        public string Biography { get; set; }
    }
}
