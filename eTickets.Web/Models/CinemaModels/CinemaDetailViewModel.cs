using eTickets.entities;

namespace eTickets.Web.Models.CinemaModels
{
    public class CinemaDetailViewModel
    {
        public DateTime Opentime { get; set; }
        public DateTime Closetime { get; set; }
        public string Address { get; set; }
        public CinemaDetailViewModel()
        {
            Movies = new List<Movie>();
        }
        public List<Movie> Movies { get; set; }
    }
}
