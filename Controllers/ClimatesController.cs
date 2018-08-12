using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNetCoreSqlDb.Models;

namespace DotNetCoreSqlDb.Controllers
{
    public class ClimatesController : Controller
    {
        private readonly MyDatabaseContext _context;

        public ClimatesController(MyDatabaseContext context)
        {
            _context = context;    
        }

        // GET: Climates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Climate.ToListAsync());
        }

        // GET: Climates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var climate = await _context.Climate
                .SingleOrDefaultAsync(m => m.ClimateID == id);
            if (climate == null)
            {
                return NotFound();
            }

            return View(climate);
        }

        // GET: Climates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Climates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClimateID,Name,Description,Rain_in_Winter,Rain_during_Growing_Season,Rain_during_Harvest,Temp_in_Winter,Temp_during_Growing_Season,Temp_Continentality,Temp_Diurnal,Vintage_Variation,Proximity_to_Large_Bodies_of_Water")] Climate climate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(climate);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(climate);
        }

        // GET: Climates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var climate = await _context.Climate.SingleOrDefaultAsync(m => m.ClimateID == id);
            if (climate == null)
            {
                return NotFound();
            }
            return View(climate);
        }

        // POST: Climates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClimateID,Name,Description,Rain_in_Winter,Rain_during_Growing_Season,Rain_during_Harvest,Temp_in_Winter,Temp_during_Growing_Season,Temp_Continentality,Temp_Diurnal,Vintage_Variation,Proximity_to_Large_Bodies_of_Water")] Climate climate)
        {
            if (id != climate.ClimateID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(climate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClimateExists(climate.ClimateID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(climate);
        }

        // GET: Climates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var climate = await _context.Climate
                .SingleOrDefaultAsync(m => m.ClimateID == id);
            if (climate == null)
            {
                return NotFound();
            }

            return View(climate);
        }

        // POST: Climates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var climate = await _context.Climate.SingleOrDefaultAsync(m => m.ClimateID == id);
            _context.Climate.Remove(climate);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ClimateExists(int id)
        {
            return _context.Climate.Any(e => e.ClimateID == id);
        }
    }
}
