using eTickets.Utilities.Enum;

namespace eTickets.Web.Models.MoviesModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double price { get; set; }
        public MovieCategory Category { get; set; }
    }
}
