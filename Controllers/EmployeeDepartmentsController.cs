using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KLOVE_ASSIGNMENT.Models;

namespace KLOVE_ASSIGNMENT.Controllers
{
    public class EmployeedepartmentsController : Controller
    {
        private readonly KLOVE_ASSIGNMENTContext _context;

        public EmployeedepartmentsController(KLOVE_ASSIGNMENTContext context)
        {
            _context = context;
        }

        // GET: Employeedepartments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employeedepartment.ToListAsync());
        }

        // GET: Employeedepartments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employeedepartment = await _context.Employeedepartment
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Employeedepartment == null)
            {
                return NotFound();
            }

            return View(Employeedepartment);
        }

        // GET: Employeedepartments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employeedepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,EmployeeID,DepartmentID")] Employeedepartment Employeedepartment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Employeedepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Employeedepartment);
        }

        // GET: Employeedepartments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employeedepartment = await _context.Employeedepartment.FindAsync(id);
            if (Employeedepartment == null)
            {
                return NotFound();
            }
            return View(Employeedepartment);
        }

        public ActionResult DepartmentEmps(int? id)
        {
            IEnumerable<Employeedepartment> Employeedepartment =  from xxx in _context.Employeedepartment where xxx.DepartmentID == id select xxx;
            return View(Employeedepartment);
        }
     
     

        // POST: Employeedepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,EmployeeID,DepartmentID")] Employeedepartment Employeedepartment)
        {
            if (id != Employeedepartment.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Employeedepartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeedepartmentExists(Employeedepartment.ID))
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
            return View(Employeedepartment);
        }

        // GET: Employeedepartments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employeedepartment = await _context.Employeedepartment
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Employeedepartment == null)
            {
                return NotFound();
            }

            return View(Employeedepartment);
        }

        // POST: Employeedepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Employeedepartment = await _context.Employeedepartment.FindAsync(id);
            _context.Employeedepartment.Remove(Employeedepartment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeedepartmentExists(int id)
        {
            return _context.Employeedepartment.Any(e => e.ID == id);
        }
    }
}
