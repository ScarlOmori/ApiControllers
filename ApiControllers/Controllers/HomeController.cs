using ApiControllers.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiControllers.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Reservations);
        [HttpPost]
        public IActionResult AddReservation(Reservation reservation) 
        {
            repository.AddReservation(reservation);
            return RedirectToAction(nameof(Index));
        }
    }
}
    