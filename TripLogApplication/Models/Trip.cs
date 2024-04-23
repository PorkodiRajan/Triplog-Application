using System.ComponentModel.DataAnnotations;

namespace TripLogApplication.Models
{
    public class Trip
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Destination is required")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string Accommodation { get; set; }

        public string AccommodationPhone { get; set; }

        public string AccommodationEmail { get; set; }

        public string ThingsToDo1 { get; set; }
        public string ThingsToDo2 { get; set; }
        public string ThingsToDo3 { get; set; }
    }
}
