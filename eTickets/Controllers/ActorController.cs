using Microsoft.AspNetCore.Mvc;
using eTickets.Application.Services.Interfaces;
using AutoMapper;
using eTickets.ViewModel;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IActorService _actorService;

        public ActorController(IMapper mapper, IActorService actorService)
        {
            _mapper = mapper;
            _actorService = actorService;
        }

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var actor = await _actorService.GetAllListAsync(cancellationToken);
            var model = _mapper.Map<List<ActorViewModel>>(actor);
            return View(model);
        }

        //Get: Actors/Create
        public async Task<IActionResult> Create()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            return View();
        }
    }
}
