using eTickets.Utilities.Enum;

namespace eTickets.Web.Models.Movie
{
    public class MovieListViewModel
    {
        public string Name { get; set; }
        public double price { get; set; }
        public string ImageURL { get; set; }
        public MovieCategory Category { get; set; }
    }
}
