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
using eTickets.Web.Models.Cinema;

namespace eTickets.Web.Controllers
{
    #region Data and Const
    public class CinemasController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CinemasController(ApplicationDbContext context ,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Actions
        
        public async Task<IActionResult> Index()
        {
            var Cinemas = await _context.Theatres.ToListAsync();  //Brings a list of type (entity)cinemas from the database

            var CinemaVMs = _mapper.Map<List<Cinema>, List<CinemaViewModel>>(Cinemas);   //converts the list of type (entity) to a list of type (viewmodel) 

                return View(CinemaVMs); // returns the view of the model

        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Theatres == null)
            {
                return NotFound();
            }

            var cinema = await _context.Theatres.FirstOrDefaultAsync(m => m.Id == id);
            var cinemaVms = _mapper.Map<Cinema,CinemaDetailViewModel>(cinema);
            if (cinema == null)
            {
                return NotFound();
            }

            return View(cinemaVms);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CinemaViewModel cinemaVM)
        {
            if (ModelState.IsValid)
            {
                var Cinema = _mapper.Map<CinemaViewModel, Cinema>(cinemaVM);
                _context.Add(cinemaVM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cinemaVM);
        }

       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Theatres == null)
            {
                return NotFound();
            }

            var cinema = await _context.Theatres.FindAsync(id);

            var cinemaVms = _mapper.Map<Cinema, CinemaViewModel>(cinema);

            if (cinema == null)
            {
                return NotFound();
            }
            return View(cinemaVms);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CinemaViewModel cinemaVms)
        {
            if (id != cinemaVms.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var cinema = _mapper.Map<CinemaViewModel,Cinema>(cinemaVms);
                    _context.Update(cinema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CinemaExists(cinemaVms.Id))
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
            return View(cinemaVms);
        }

        // GET: Cinemas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Theatres == null)
            {
                return NotFound();
            }

            var cinema = await _context.Theatres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }

            return View(cinema);
        }

        // POST: Cinemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Theatres == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Theatres'  is null.");
            }
            var cinema = await _context.Theatres.FindAsync(id);
            if (cinema != null)
            {
                _context.Theatres.Remove(cinema);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Private Funtions
        private bool CinemaExists(int id)
        {
          return (_context.Theatres?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        #endregion
    }

}
