using AutoMapper;
using eTickets.Application.Services.Interfaces;
using eTickets.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICinemaService _service;

        public CinemaController(IMapper mapper, ICinemaService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var cinemas = await _service.GetAllListAsync(cancellationToken);
            var model = _mapper.Map<List<CinemaViewModel>>(cinemas);

            return View(model);
        }
    }
}
