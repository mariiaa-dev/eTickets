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
            CancellationToken _cancellationToken = HttpContext.RequestAborted;
            var service =
                await _produserService.GetProducersListAsync(_cancellationToken);
            return View();
        }
    }
}
