using eTickets.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService) => _movieService = movieService;

        public async Task<IActionResult> Index()
        {
            CancellationToken _cancellationToken = HttpContext.RequestAborted;
            var service = await _movieService.GetMoviesListAsync(_cancellationToken);

            return View();
        }
    }
}
