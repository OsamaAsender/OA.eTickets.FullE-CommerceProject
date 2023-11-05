using eTickets.entities;

namespace eTickets.entities
{
    public class MovieDetailViewModel
    {
        public MovieDetailViewModel()
        {
            Actors = new List<Actor>();
        }
        public List<Actor> Actors { get; set; }
        public Producer producer { get; set; }
        public string ImageURL { get; set; }
        public Cinema Theatre { get; set; }

    }
}
