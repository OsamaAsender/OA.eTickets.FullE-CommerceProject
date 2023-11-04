using eTickets.Utilities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.entities
{
    public class Producer
    {
        public Producer() {
            Movies = new List<Movie>();
        }
        public List<Movie> Movies { get; set; }
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Biography { get; set; }
        public Gender Sex { get; set; }
    }
}