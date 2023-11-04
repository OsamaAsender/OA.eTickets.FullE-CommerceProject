using eTickets.Utilities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.entities
{
    public class Movie
    {
        public Movie() { 
            Actors = new List<Actor>();
        }
        public List<Actor> Actors { get; set; }
        public Producer producer { get; set; }
        public Cinema Theatre { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }  
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory Category { get; set; }
    }
}
