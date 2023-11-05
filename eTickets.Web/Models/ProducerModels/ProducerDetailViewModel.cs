using eTickets.entities;

namespace eTickets.Web.Models.ProducerModels
{
    public class ProducerDetailViewModel
    {
        public ProducerDetailViewModel()
        {
            Movies = new List<Movie>();
        }
        public List<Movie> Movies { get; set; }
        public string Biography { get; set; }
    }
}
