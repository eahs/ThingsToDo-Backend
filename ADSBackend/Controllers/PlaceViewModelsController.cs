using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ADSBackend.Data;
using ADSBackend.Models.PlaceViewModels;

namespace ADSBackend.Controllers
{
    public class PlaceViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlaceViewModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlaceViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlaceViewModel.ToListAsync());
        }

        // GET: PlaceViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placeViewModel = await _context.PlaceViewModel
                .FirstOrDefaultAsync(m => m.PlaceId == id);
            if (placeViewModel == null)
            {
                return NotFound();
            }

            return View(placeViewModel);
        }

        // GET: PlaceViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlaceViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlaceId,Name,Location")] PlaceViewModel placeViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(placeViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(placeViewModel);
        }

        // GET: PlaceViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placeViewModel = await _context.PlaceViewModel.FindAsync(id);
            if (placeViewModel == null)
            {
                return NotFound();
            }
            return View(placeViewModel);
        }

        // POST: PlaceViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlaceId,Name,Location")] PlaceViewModel placeViewModel)
        {
            if (id != placeViewModel.PlaceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(placeViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaceViewModelExists(placeViewModel.PlaceId))
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
            return View(placeViewModel);
        }

        // GET: PlaceViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placeViewModel = await _context.PlaceViewModel
                .FirstOrDefaultAsync(m => m.PlaceId == id);
            if (placeViewModel == null)
            {
                return NotFound();
            }

            return View(placeViewModel);
        }

        // POST: PlaceViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var placeViewModel = await _context.PlaceViewModel.FindAsync(id);
            _context.PlaceViewModel.Remove(placeViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaceViewModelExists(int id)
        {
            return _context.PlaceViewModel.Any(e => e.PlaceId == id);
        }
    }
}
