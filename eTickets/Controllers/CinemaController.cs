using eTickets.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService _cinemaService;

        public CinemaController(ICinemaService cinemaService) => _cinemaService = cinemaService;

        public async Task<IActionResult> Index()
        {
            CancellationToken _cancellationToken = HttpContext.RequestAborted;
            var model = await _cinemaService.GetCinemasListAsync(_cancellationToken);

            return View(model);
        }
    }
}
