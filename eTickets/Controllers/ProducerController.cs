using AutoMapper;
using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
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

            var models =
                await _service.GetAllListAsync(cancellationToken);

            var viewModels = _mapper.Map<List<ProducerWithIdViewModel>>(models);

            return View(viewModels);
        }

        //Get: Producer/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProducerViewModel viewModel)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var model = _mapper.Map<Producer>(viewModel);
            await _service.AddAsync(model, cancellationToken);

            return RedirectToAction("Index");
        }

        //Get: Producer/Details/1
        public async Task<IActionResult> Details(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var details = await _service.GetByIdAsync(id, cancellationToken);

            if (details == null)
            {
                return View("NotFound");
            }

            var detailsModel = _mapper.Map<ProducerWithIdViewModel>(details);

            return View(detailsModel);
        }

        //Get: Producer/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var details = await _service.GetByIdAsync(id, cancellationToken);
            if (details == null)
            {
                return View("NotFound");
            }

            var detailsModel = _mapper.Map<ProducerViewModel>(details);

            return View(detailsModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProducerWithIdViewModel viewModel)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var model = _mapper.Map<Producer>(viewModel);
            await _service.UpdateAsync(id, model, cancellationToken);

            return RedirectToAction("Index");
        }

        //Get: Producer/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            var details = await _service.GetByIdAsync(id, cancellationToken);
            if (details == null)
            {
                return View("NotFound");
            }

            var detailsModel = _mapper.Map<ProducerWithIdViewModel>(details);

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
