using eTickets.Utilities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.entities
{
    public class Actor
    {
        public Actor() {

           Movies = new List<Movie>();
        }

        public List<Movie> Movies { get; set; }
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
