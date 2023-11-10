﻿using eTickets.entities;
using eTickets.Utilities.Enum;
using eTickets.Web.Models.Movie;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Web.Models.Actor
{
    public class ActorDetailViewModel
    {
        public ActorDetailViewModel(){

            Movies = new List<MovieListViewModel>();
        }

        public List<MovieListViewModel> Movies { get; set; }
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Biography { get; set; }
    }
}
