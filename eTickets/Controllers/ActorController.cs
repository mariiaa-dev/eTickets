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

            var models = await _service.GetAllListAsync(cancellationToken);

            var viewModels = _mapper.Map<List<ActorWithIdViewModel>>(models);

            return View(viewModels);
        }

        //Get: Actor/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ActorViewModel viewModel)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var model = _mapper.Map<Actor>(viewModel);
            await _service.AddAsync(model, cancellationToken);

            return RedirectToAction("Index");
        }

        //Get: Actor/Details/1
        public async Task<IActionResult> Details(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var details = await _service.GetByIdAsync(id, cancellationToken);
            if (details == null)
            {
                return View("NotFound");
            }

            var detailsModel = _mapper.Map<ActorWithIdViewModel>(details);

            return View(detailsModel);
        }

        //Get: Actor/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var details = await _service.GetByIdAsync(id, cancellationToken);
            if (details == null)
            {
                return View("NotFound");
            }

            var detailsModel = _mapper.Map<ActorViewModel>(details);

            return View(detailsModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ActorWithIdViewModel viewModel)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var model = _mapper.Map<Actor>(viewModel);
            await _service.UpdateAsync(id, model, cancellationToken);

            return RedirectToAction("Index");
        }

        //Get: Actor/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var details = await _service.GetByIdAsync(id, cancellationToken);
            if (details == null)
            {
                return View("NotFound");
            }

            var detailsModel = _mapper.Map<ActorWithIdViewModel>(details);

            return View(detailsModel);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var details = await _service.GetByIdAsync(id, cancellationToken);
            if (details == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id, cancellationToken);            

            return RedirectToAction("Index");
        }
    }
}
