using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Casa_Do_Suplemento.Context;
using Casa_Do_Suplemento.Models;
using Microsoft.AspNetCore.Authorization;
using ReflectionIT.Mvc.Paging;

namespace Casa_Do_Suplemento.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminSuplementoController : Controller
    {
        private readonly AppDbContext _context;

        public AdminSuplementoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminSuplemento
        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "Nome")
        {
            var resultado = _context.Suplementos.AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrEmpty(filter))
            {
                resultado = resultado.Where(p => p.Nome.Contains(filter));
            }

            var model = await PagingList.CreateAsync(resultado, 5, pageindex, sort, "Nome");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };
            return View(model);
        }

        // GET: Admin/AdminSuplemento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplemento = await _context.Suplementos
                .Include(s => s.Categoria)
                .FirstOrDefaultAsync(m => m.SuplementoId == id);
            if (suplemento == null)
            {
                return NotFound();
            }

            return View(suplemento);
        }

        // GET: Admin/AdminSuplemento/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName");
            return View();
        }

        // POST: Admin/AdminSuplemento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SuplementoId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsSuplementoFavorito,EmEstoque,CategoriaId")] Suplemento suplemento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suplemento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", suplemento.CategoriaId);
            return View(suplemento);
        }

        // GET: Admin/AdminSuplemento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplemento = await _context.Suplementos.FindAsync(id);
            if (suplemento == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", suplemento.CategoriaId);
            return View(suplemento);
        }

        // POST: Admin/AdminSuplemento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SuplementoId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsSuplementoFavorito,EmEstoque,CategoriaId")] Suplemento suplemento)
        {
            if (id != suplemento.SuplementoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suplemento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuplementoExists(suplemento.SuplementoId))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", suplemento.CategoriaId);
            return View(suplemento);
        }

        // GET: Admin/AdminSuplemento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplemento = await _context.Suplementos
                .Include(s => s.Categoria)
                .FirstOrDefaultAsync(m => m.SuplementoId == id);
            if (suplemento == null)
            {
                return NotFound();
            }

            return View(suplemento);
        }

        // POST: Admin/AdminSuplemento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suplemento = await _context.Suplementos.FindAsync(id);
            _context.Suplementos.Remove(suplemento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuplementoExists(int id)
        {
            return _context.Suplementos.Any(e => e.SuplementoId == id);
        }
    }
}
