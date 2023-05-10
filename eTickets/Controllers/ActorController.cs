using Microsoft.AspNetCore.Mvc;
using eTickets.Application.Services.Interfaces;
using AutoMapper;
using eTickets.ViewModel;
using eTickets.Domains.Models;
using System.Threading;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IActorService _service;

        public ActorController(IMapper mapper, IActorService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var actors = await _service.GetAllListAsync(cancellationToken);

            var model = _mapper.Map<List<ActorWithIdViewModel>>(actors);

            return View(model);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ActorViewModel model)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var actor = _mapper.Map<Actor>(model);
            await _service.AddAsync(actor, cancellationToken);

            return RedirectToAction("Index");
        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var actorDetails = await _service.GetByIdAsync(id, cancellationToken);
            if (actorDetails == null)
            {
                return View("NotFound");
            }

            var actorDetailsModel = _mapper.Map<ActorWithIdViewModel>(actorDetails);

            return View(actorDetailsModel);
        }

        //Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var actorDetails = await _service.GetByIdAsync(id, cancellationToken);
            if (actorDetails == null)
            {
                return View("NotFound");
            }

            var actorDetailsModel = _mapper.Map<ActorViewModel>(actorDetails);

            return View(actorDetailsModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ActorWithIdViewModel model)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var actor = _mapper.Map<Actor>(model);
            await _service.UpdateAsync(id, actor, cancellationToken);

            return RedirectToAction("Index");
        }

        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var actorDetails = await _service.GetByIdAsync(id, cancellationToken);
            if (actorDetails == null)
            {
                return View("NotFound");
            }

            var actorDetailsModel = _mapper.Map<ActorWithIdViewModel>(actorDetails);

            return View(actorDetailsModel);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var actorDetails = await _service.GetByIdAsync(id, cancellationToken);
            if (actorDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id, cancellationToken);            

            return RedirectToAction("Index");
        }
    }
}
