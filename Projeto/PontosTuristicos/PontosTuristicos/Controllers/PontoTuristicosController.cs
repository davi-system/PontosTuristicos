using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PontosTuristicos.Data;
using PontosTuristicos.Models;

namespace PontosTuristicos.Controllers
{
    public class PontoTuristicosController : Controller
    {
        private readonly PontosTuristicosContext _context;

        public PontoTuristicosController(PontosTuristicosContext context)
        {
            _context = context;
        }

        // GET: PontoTuristicos        
        public async Task<IActionResult> Index(string nomePontoTuristico)
        {
            var pontoTuristico = from p in _context.PontoTuristico select p;

            if (!String.IsNullOrEmpty(nomePontoTuristico))
            {
                pontoTuristico = pontoTuristico.Where(s => s.Nome.Contains(nomePontoTuristico));
            }

            return View(await pontoTuristico.ToListAsync());
        }        

        // GET: PontoTuristicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pontoTuristico = await _context.PontoTuristico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pontoTuristico == null)
            {
                return NotFound();
            }

            return View(pontoTuristico);
        }

        // GET: PontoTuristicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PontoTuristicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cidade,Estado,Nome,Referencia,Descricao")] PontoTuristico pontoTuristico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pontoTuristico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pontoTuristico);
        }

        // GET: PontoTuristicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pontoTuristico = await _context.PontoTuristico.FindAsync(id);
            if (pontoTuristico == null)
            {
                return NotFound();
            }
            return View(pontoTuristico);
        }

        // POST: PontoTuristicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cidade,Estado,Nome,Referencia,Descricao")] PontoTuristico pontoTuristico)
        {
            if (id != pontoTuristico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pontoTuristico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PontoTuristicoExists(pontoTuristico.Id))
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
            return View(pontoTuristico);
        }

        // GET: PontoTuristicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pontoTuristico = await _context.PontoTuristico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pontoTuristico == null)
            {
                return NotFound();
            }

            return View(pontoTuristico);
        }

        // POST: PontoTuristicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pontoTuristico = await _context.PontoTuristico.FindAsync(id);
            _context.PontoTuristico.Remove(pontoTuristico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PontoTuristicoExists(int id)
        {
            return _context.PontoTuristico.Any(e => e.Id == id);
        }
    }
}
