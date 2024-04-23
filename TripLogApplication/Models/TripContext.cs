using Microsoft.EntityFrameworkCore;
using TripLogApplication.Models;

namespace TripLogApplication.Data
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options) : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Trip entity
            modelBuilder.Entity<Trip>().HasData(
            new Trip { Id = 1, Destination = "US", Accommodation = "Porkodi", StartDate = DateTime.Today, EndDate = DateTime.Today, AccommodationPhone = "32423423434",
           AccommodationEmail = "porkodi@gmail.com", ThingsToDo1 = "swim",
                ThingsToDo2 = "swim",
                ThingsToDo3 = "swim"
            });

        }
    }
}
