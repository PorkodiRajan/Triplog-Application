using Microsoft.AspNetCore.Mvc;
using TripLogApplication.Data;
using TripLogApplication.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace TripLogApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly TripContext _context;

        public HomeController(TripContext context)
        {
            _context = context;
        }

        public IActionResult AddTrip()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTrip(string destination, string accommodation, DateTime startDate, DateTime endDate)
        {
            TempData["Destination"] = destination;
            TempData["Accommodation"] = accommodation;
            TempData["StartDate"] = startDate;
            TempData["EndDate"] = endDate;

            return RedirectToAction("AddAccommodations");
        }
        public IActionResult AddAccommodations()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAccommodations(string accommodationPhone, string accommodationEmail)
        {
            TempData["AccommodationPhone"] = accommodationPhone;
            TempData["AccommodationEmail"] = accommodationEmail;

            return RedirectToAction("AddThingsToDo");
        }

        // GET: /Trip/AddThingsToDo
        public IActionResult AddThingsToDo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddThingsToDo(string ThingsToDo1, string ThingsToDo2, string ThingsToDo3)
        {
            TempData["ThingsToDo1"] = ThingsToDo1;
            TempData["ThingsToDo2"] = ThingsToDo2;
            TempData["ThingsToDo3"] = ThingsToDo3;

            if (TempData["Destination"] == null || TempData["Accommodation"] == null ||
                TempData["StartDate"] == null || TempData["EndDate"] == null ||
                TempData["AccommodationPhone"] == null || TempData["AccommodationEmail"] == null)
            {
                // Handle missing TempData values
                return RedirectToAction("Index");
            }

            var trip = new Trip
            {
                Destination = TempData["Destination"].ToString(),
                StartDate = DateTime.Parse(TempData["StartDate"].ToString()),
                EndDate = DateTime.Parse(TempData["EndDate"].ToString()),
                Accommodation = TempData["Accommodation"].ToString(),
                AccommodationPhone = TempData["AccommodationPhone"].ToString(),
                AccommodationEmail = TempData["AccommodationEmail"].ToString(),
                ThingsToDo1 = TempData["ThingsToDo1"]?.ToString(),
                ThingsToDo2 = TempData["ThingsToDo2"]?.ToString(),
                ThingsToDo3 = TempData["ThingsToDo3"]?.ToString()
            };

            _context.Trips.Add(trip);
            _context.SaveChanges();

            TempData["TripAdded"] = "  Trip  to  " + TempData["Destination"] as string + "  added  ";

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            //TempData.Clear();

            var trips = _context.Trips.ToList();
            return View(trips);
        }

        [HttpPost]
        public IActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index");
        }
    }
}

