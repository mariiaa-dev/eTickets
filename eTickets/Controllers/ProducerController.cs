﻿using AutoMapper;
using eTickets.Application.Services.Interfaces;
using eTickets.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProducerService _produserService;

        public ProducerController(IMapper mapper, IProducerService produserService)
        {
            _mapper = mapper;
            _produserService = produserService;
        }

        public async Task<IActionResult> Index()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var producers =
                await _produserService.GetAllListAsync(cancellationToken);
            var model = _mapper.Map<List<ProducerViewModel>>(producers);

            return View(model);
        }
    }
}
