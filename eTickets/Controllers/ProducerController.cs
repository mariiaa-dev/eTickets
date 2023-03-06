using Microsoft.AspNetCore.Mvc;
using eTickets.Application.Services.Interfaces;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _produserService;

        public ProducerController(IProducerService produserService) => _produserService = produserService;

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var model =
                await _produserService.GetProducersListAsync(cancellationToken);
            return View(model);
        }
    }
}
