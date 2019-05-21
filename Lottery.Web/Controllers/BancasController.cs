namespace Lottery.Web.Controllers
{
    using System.Threading.Tasks;
    using Data;
    using Data.Entities;
    using Helpers;
    using Lottery.Web.Data.Repositories;
    using Lottery.Web.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class BancasController : Controller
    {
        private readonly IBancaRepository bancaRepository;
        private readonly IUserHelper userHelper;

        public BancasController(IBancaRepository bancaRepository, IUserHelper userHelper)
        {
            this.bancaRepository = bancaRepository;
            this.userHelper = userHelper;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View(this.bancaRepository.GetAll());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.bancaRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            var Owner = new BancaViewModel
            {
                Owner = this.bancaRepository.GetComboOwner()
            };

            var Location = new BancaViewModel
            {
                Location = this.bancaRepository.GetComboLocation()
            };
            return this.View(Location);
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Banca banca)
        {
            if (ModelState.IsValid)
            {
                // TODO: Pending to change to: this.User.Identity.Name
                banca.User = await this.userHelper.GetUserByEmailAsync("paulinoenrique@gmail.com");
                await this.bancaRepository.CreateAsync(banca);
                return RedirectToAction(nameof(Index));
            }

            return View(banca);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.bancaRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Banca banca)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Pending to change to: this.User.Identity.Name
                    banca.User = await this.userHelper.GetUserByEmailAsync("jzuluaga55@gmail.com");
                    await this.bancaRepository.UpdateAsync(banca);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.bancaRepository.ExistAsync(banca.Id))
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

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.bancaRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await this.bancaRepository.GetByIdAsync(id);
            await this.bancaRepository.DeleteAsync(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
