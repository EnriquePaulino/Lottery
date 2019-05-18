using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lottery.Web.Data;
using Lottery.Web.Data.Entities;
using Lottery.Web.Data.Repositories;

namespace Lottery.Web.Controllers
{
    public class BancasController : Controller
    {
        private readonly IRepository repository;

        public BancasController(IRepository repository)
        {
            this.repository = repository;
        }

        // GET: Bancas
        public IActionResult Index()
        {
            return View(this.repository.GetBancas());
        }

        // GET: Bancas/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banca = this.repository.GetBanca(id.Value);
            if (banca == null)
            {
                return NotFound();
            }

            return View(banca);
        }

        // GET: Bancas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bancas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Banca banca)
        {
            if (ModelState.IsValid)
            {
                this.repository.AddBanca(banca);
                await this.repository.SaveAllAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banca);
        }

        // GET: Bancas/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banca = this.repository.GetBanca(id.Value);
            if (banca == null)
            {
                return NotFound();
            }

            return View(banca);
        }

        // POST: Bancas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Banca banca)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.repository.UpdateBanca(banca);
                    await this.repository.SaveAllAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.repository.BancaExists(banca.Id))
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

            return View(banca);
        }

        // GET: Bancas/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banca = this.repository.GetBanca(id.Value);
            if (banca == null)
            {
                return NotFound();
            }

            return View(banca);
        }

        // POST: Bancas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var banca = this.repository.GetBanca(id);
            this.repository.RemoveBanca(banca);
            await this.repository.SaveAllAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
