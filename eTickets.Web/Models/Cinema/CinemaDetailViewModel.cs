using eTickets.entities;
using eTickets.Web.Models.Movie;

namespace eTickets.Web.Models.Cinema
{
    public class CinemaDetailViewModel
    {
        public int Id { get; set; }
        public DateTime Opentime { get; set; }
        public DateTime Closetime { get; set; }
        public string Address { get; set; }
      
    }
}
