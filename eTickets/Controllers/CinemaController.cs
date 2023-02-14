using eTickets.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService _cinemaService;

        public CinemaController(ICinemaService cinemaService) => _cinemaService = cinemaService;

        public IActionResult Index()
        {
            CancellationToken _cancellationToken = HttpContext.RequestAborted;
            var service = _cinemaService.GetCinemasListAsync(_cancellationToken);

            return View();
        }
    }
}
