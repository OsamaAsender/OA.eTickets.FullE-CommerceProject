using eTickets.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Cinema> Theatres { get; set; }
        public DbSet <Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}