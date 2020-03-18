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
    public class CaixaArquivoController : Controller
    {
        private readonly ArquivarmeDbContext _context;

        public CaixaArquivoController(ArquivarmeDbContext context)
        {
            _context = context;
        }

        // GET: CaixaArquivo
        public async Task<IActionResult> Index()
        {
            var arquivarmeDbContext = _context.CaixaArquivo.Include(c => c.Empresa);
            return View(await arquivarmeDbContext.ToListAsync());
        }

        // GET: CaixaArquivo/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixaArquivo = await _context.CaixaArquivo
                .Include(c => c.Empresa)
                .FirstOrDefaultAsync(m => m.CaixaArquivoId == id);
            if (caixaArquivo == null)
            {
                return NotFound();
            }

            return View(caixaArquivo);
        }

        // GET: CaixaArquivo/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "EmpresaId", "Bairro");
            return View();
        }

        // POST: CaixaArquivo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CaixaArquivoId,Entrege,DataCriacao,EmpresaId")] CaixaArquivo caixaArquivo)
        {
            if (ModelState.IsValid)
            {
                caixaArquivo.CaixaArquivoId = Guid.NewGuid();
                _context.Add(caixaArquivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "EmpresaId", "Bairro", caixaArquivo.EmpresaId);
            return View(caixaArquivo);
        }

        // GET: CaixaArquivo/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixaArquivo = await _context.CaixaArquivo.FindAsync(id);
            if (caixaArquivo == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "EmpresaId", "Bairro", caixaArquivo.EmpresaId);
            return View(caixaArquivo);
        }

        // POST: CaixaArquivo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CaixaArquivoId,Entrege,DataCriacao,EmpresaId")] CaixaArquivo caixaArquivo)
        {
            if (id != caixaArquivo.CaixaArquivoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caixaArquivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaixaArquivoExists(caixaArquivo.CaixaArquivoId))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "EmpresaId", "Bairro", caixaArquivo.EmpresaId);
            return View(caixaArquivo);
        }

        // GET: CaixaArquivo/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixaArquivo = await _context.CaixaArquivo
                .Include(c => c.Empresa)
                .FirstOrDefaultAsync(m => m.CaixaArquivoId == id);
            if (caixaArquivo == null)
            {
                return NotFound();
            }

            return View(caixaArquivo);
        }

        // POST: CaixaArquivo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var caixaArquivo = await _context.CaixaArquivo.FindAsync(id);
            _context.CaixaArquivo.Remove(caixaArquivo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaixaArquivoExists(Guid id)
        {
            return _context.CaixaArquivo.Any(e => e.CaixaArquivoId == id);
        }
    }
}
