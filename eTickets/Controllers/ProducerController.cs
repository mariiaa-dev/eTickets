using eTickets.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
                await _produserService.GetAllListAsync(cancellationToken);
            return View(model);
        }
    }
}
