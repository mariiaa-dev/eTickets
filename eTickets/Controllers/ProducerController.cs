using AutoMapper;
using eTickets.Application.Services.Interfaces;
using eTickets.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProducerService _service;

        public ProducerController(IMapper mapper, IProducerService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var producers =
                await _service.GetAllListAsync(cancellationToken);
            var model = _mapper.Map<List<ProducerViewModel>>(producers);

            return View(model);
        }
    }
}
