﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Web.Models.Cinema
{
    public class CinemaViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public DateTime Opentime { get; set; }
        public DateTime Closetime { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
