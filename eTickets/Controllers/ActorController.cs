using Microsoft.AspNetCore.Mvc;
using eTickets.Application.Services.Interfaces;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService) => _actorService = actorService;

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var model = await _actorService.GetAllListAsync(cancellationToken);
            return View(model);
        }

        //Get
        public async Task<IActionResult> Create()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            return View();
        }
    }
}
 