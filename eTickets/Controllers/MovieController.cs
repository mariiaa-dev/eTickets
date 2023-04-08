using AutoMapper;
using eTickets.Application.Services.Interfaces;
using eTickets.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMovieService _movieService;

        public MovieController(IMapper mapper, IMovieService movieService)
        {
            _mapper = mapper;
            _movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var movies = await _movieService.GetAllListAsync(cancellationToken);
            var model = _mapper.Map<List<MovieViewModel>>(movies);

            return View(model);
        }
    }
}
