using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Web.Models.Actor
{
    public class ActorViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{Firstname} {Lastname}";
            }
        }
        public string ProfilePictureURL { get; set; }
        public string Biography { get; set; }
    }
}
