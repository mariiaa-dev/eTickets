using AutoMapper;
using eTickets.Application.Services.Interfaces;
using eTickets.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMovieService _service;

        public MovieController(IMapper mapper, IMovieService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var movies = await _service.GetAllListAsync(cancellationToken);
            var model = _mapper.Map<List<MovieViewModel>>(movies);

            return View(model);
        }
    }
}
