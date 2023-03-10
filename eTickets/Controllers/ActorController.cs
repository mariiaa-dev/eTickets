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
            var model = await _actorService.GetActorsListAsync(cancellationToken);
            return View(model);
        }
    }
}
