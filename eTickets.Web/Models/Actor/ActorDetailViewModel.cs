using eTickets.entities;
using eTickets.Utilities.Enum;
using eTickets.Web.Models.MoviesModels;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Web.Models.Actor
{
    public class ActorDetailViewModel
    {
        public ActorDetailViewModel(){

            Movies = new List<MovieViewModel>();
        }

        public List<MovieViewModel> Movies { get; set; }
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Nationality { get; set; }
        public string Biography { get; set; }
        public string MaritalStatus { get; set; }
        public int Kids { get; set; }
        public Gender Sex { get; set; }
    }
}
