using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eTickets.Web.Data;
using eTickets.entities;
using AutoMapper;
using eTickets.Web.Models.Producer;

namespace eTickets.Web.Controllers
{
    #region data and const
    public class ProducersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProducersController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #endregion

        #region Actions
        public async Task<IActionResult> Index()
        {

           var producer = await _context.Producers.ToListAsync();
            var producerVms = _mapper.Map<List<Producer>, List<ProducerViewModel>>(producer);
            return View(producerVms);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Producers == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers .FirstOrDefaultAsync(m => m.Id == id);

            var producerVM = _mapper.Map<Producer,ProducerDetailViewModel>(producer);

            if (producer == null)
            {
                return NotFound();
            }

            return View(producerVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProducerViewModel producerVM)
        {
            if (ModelState.IsValid)
            {
                var producer = _mapper.Map<ProducerViewModel,Producer>(producerVM);

                _context.Add(producerVM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producerVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Producers == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers.FindAsync(id);
            var producerVM = _mapper.Map<Producer,ProducerViewModel>(producer);
            if (producer == null)
            {
                return NotFound();
            }
            return View(producerVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProducerViewModel producerVM)
        {
            if (id != producerVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var producer = _mapper.Map<ProducerViewModel,Producer>(producerVM);
                    _context.Update(producer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProducerExists(producerVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producerVM);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Producers == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Producers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Producers'  is null.");
            }
            var producer = await _context.Producers.FindAsync(id);
            if (producer != null)
            {
                _context.Producers.Remove(producer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Private Functions
        private bool ProducerExists(int id)
        {
          return (_context.Producers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
    #endregion
}
