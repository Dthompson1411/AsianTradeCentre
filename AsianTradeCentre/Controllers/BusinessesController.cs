using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AsianTradeCentre.Models;

namespace AsianTradeCentre.Controllers
{
    public class BusinessesController : Controller
    {
        private readonly AsianTradeCentreContext _context;

        public BusinessesController(AsianTradeCentreContext context)
        {
            _context = context;
        }

        // GET: Businesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Business.ToListAsync());
        }

        // GET: Businesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // GET: Businesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Businesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,BusinessName,Address,City,Country,PostalCode,PhoneNum,Email,WebAddress")] Business business)
        {
            if (ModelState.IsValid)
            {
                _context.Add(business);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(business);
        }

        // GET: Businesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            return View(business);
        }

        // POST: Businesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonID,BusinessName,Address,City,Country,PostalCode,PhoneNum,Email,WebAddress")] Business business)
        {
            if (id != business.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(business);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessExists(business.PersonID))
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
            return View(business);
        }

        // GET: Businesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // POST: Businesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var business = await _context.Business.FindAsync(id);
            _context.Business.Remove(business);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessExists(int id)
        {
            return _context.Business.Any(e => e.PersonID == id);
        }
    }
}
