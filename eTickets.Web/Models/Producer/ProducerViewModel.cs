using eTickets.entities;
using eTickets.Utilities.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Web.Models.Producer
{
    public class ProducerViewModel
    {
       
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [NotMapped]
        public string Fullname {
            get
            {
                return $"{Firstname + Lastname}";
            }
        }
        public string Biography { get; set; }
        public Gender Sex { get; set; }

    }
}
