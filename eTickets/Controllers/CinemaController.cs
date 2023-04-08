using AutoMapper;
using eTickets.Application.Services.Interfaces;
using eTickets.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICinemaService _cinemaService;

        public CinemaController(IMapper mapper, ICinemaService cinemaService)
        {
            _mapper = mapper;
            _cinemaService = cinemaService;
        }

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var cinemas = await _cinemaService.GetAllListAsync(cancellationToken);
            var model = _mapper.Map<List<CinemaViewModel>>(cinemas);

            return View(model);
        }
    }
}
