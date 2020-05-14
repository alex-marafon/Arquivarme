using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Arquivarme.Data.ORM;
using Arquivarme.Dominio.Models;

namespace Arquivarme.Mvc.Controllers
{
    public class GeolocalizacaoController : Controller
    {
        private readonly ArquivarmeDbContext _context;

        public GeolocalizacaoController(ArquivarmeDbContext context)
        {
            _context = context;
        }

        // GET: Geolocalizacao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Geolocalizacao.ToListAsync());
        }

        // GET: Geolocalizacao/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geolocalizacao = await _context.Geolocalizacao
                .FirstOrDefaultAsync(m => m.GeolocalizacaoId == id);
            if (geolocalizacao == null)
            {
                return NotFound();
            }

            return View(geolocalizacao);
        }

        // GET: Geolocalizacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Geolocalizacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GeolocalizacaoId,Pais,Estado,Sigla,Cidade,CodigoIBGE")] Geolocalizacao geolocalizacao)
        {
            if (ModelState.IsValid)
            {
                geolocalizacao.GeolocalizacaoId = Guid.NewGuid();
                _context.Add(geolocalizacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(geolocalizacao);
        }

        // GET: Geolocalizacao/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geolocalizacao = await _context.Geolocalizacao.FindAsync(id);
            if (geolocalizacao == null)
            {
                return NotFound();
            }
            return View(geolocalizacao);
        }

        // POST: Geolocalizacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("GeolocalizacaoId,Pais,Estado,Sigla,Cidade,CodigoIBGE")] Geolocalizacao geolocalizacao)
        {
            if (id != geolocalizacao.GeolocalizacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(geolocalizacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeolocalizacaoExists(geolocalizacao.GeolocalizacaoId))
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
            return View(geolocalizacao);
        }

        // GET: Geolocalizacao/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geolocalizacao = await _context.Geolocalizacao
                .FirstOrDefaultAsync(m => m.GeolocalizacaoId == id);
            if (geolocalizacao == null)
            {
                return NotFound();
            }

            return View(geolocalizacao);
        }

        // POST: Geolocalizacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var geolocalizacao = await _context.Geolocalizacao.FindAsync(id);
            _context.Geolocalizacao.Remove(geolocalizacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeolocalizacaoExists(Guid id)
        {
            return _context.Geolocalizacao.Any(e => e.GeolocalizacaoId == id);
        }
    }
}
