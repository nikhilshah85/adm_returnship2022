using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeFirstMVC.Models;

namespace CodeFirstMVC.Controllers
{
    public class DeptController : Controller
    {
        private readonly EmployeeDBContext _context;

        public DeptController(EmployeeDBContext context)
        {
            _context = context;
        }

        // GET: Dept
        public async Task<IActionResult> Index()
        {
              return _context.Department != null ? 
                          View(await _context.Department.ToListAsync()) :
                          Problem("Entity set 'EmployeeDBContext.Department'  is null.");
        }

        // GET: Dept/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Department == null)
            {
                return NotFound();
            }

            var deptInfo = await _context.Department
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deptInfo == null)
            {
                return NotFound();
            }

            return View(deptInfo);
        }

        // GET: Dept/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dept/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,deptNo,deptName,deptEmail,deptContact")] DeptInfo deptInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deptInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deptInfo);
        }

        // GET: Dept/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Department == null)
            {
                return NotFound();
            }

            var deptInfo = await _context.Department.FindAsync(id);
            if (deptInfo == null)
            {
                return NotFound();
            }
            return View(deptInfo);
        }

        // POST: Dept/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,deptNo,deptName,deptEmail,deptContact")] DeptInfo deptInfo)
        {
            if (id != deptInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deptInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeptInfoExists(deptInfo.Id))
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
            return View(deptInfo);
        }

        // GET: Dept/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Department == null)
            {
                return NotFound();
            }

            var deptInfo = await _context.Department
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deptInfo == null)
            {
                return NotFound();
            }

            return View(deptInfo);
        }

        // POST: Dept/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Department == null)
            {
                return Problem("Entity set 'EmployeeDBContext.Department'  is null.");
            }
            var deptInfo = await _context.Department.FindAsync(id);
            if (deptInfo != null)
            {
                _context.Department.Remove(deptInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeptInfoExists(int id)
        {
          return (_context.Department?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
