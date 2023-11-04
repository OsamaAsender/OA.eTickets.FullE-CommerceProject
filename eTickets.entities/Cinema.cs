using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.entities
{
    public class Cinema
    {
        public Cinema() {
            Movies = new List<Movie>(); 
        }
        public List<Movie> Movies { get; set; }
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
