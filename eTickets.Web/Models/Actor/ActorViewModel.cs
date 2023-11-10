using eTickets.Utilities.Enum;
using eTickets.Web.Models.Movie;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Web.Models.Actor
{
    public class ActorViewModel
    {
        public ActorViewModel()
        {

            Movies = new List<MovieViewModel>();
        }

        public List<MovieViewModel> Movies { get; set; }
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Biography { get; set; }
    }
}
