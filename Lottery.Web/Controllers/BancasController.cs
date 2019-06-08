namespace Lottery.Web.Controllers
{
    using Data.Entities;
    using Data.Repositories;
    using Helpers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Threading.Tasks;

    [Authorize]
    public class BancasController : Controller
    {
        private readonly IBancaRepository bancaRepository;
        private readonly IUserHelper userHelper;

        public BancasController(
            IBancaRepository bancaRepository,
            IUserHelper userHelper)
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
                return new NotFoundViewResult("BancaNotFound");
            }

            var product = await this.bancaRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return new NotFoundViewResult("BancaNotFound");
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            //var model = new BancaViewModel
            //{
            //    Propietarios = this.bancaRepository.GetComboPropietarios(),
            //    Localidades = this.bancaRepository.GetComboLocalidades(),
            //    Zonas = this.bancaRepository.GetComboZonas(),
            //    Paises = this.bancaRepository.GetComboPaises()
            //};
            return this.View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Banca banca)
        {
            if (ModelState.IsValid)
            {
                banca.User = await this.userHelper.GetUserByEmailAsync(this.User.Identity.Name);
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
                return new NotFoundViewResult("BancaNotFound");
            }

            var product = await this.bancaRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return new NotFoundViewResult("BancaNotFound");
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
                    banca.User = await this.userHelper.GetUserByEmailAsync(this.User.Identity.Name);
                    await this.bancaRepository.UpdateAsync(banca);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.bancaRepository.ExistAsync(banca.Id))
                    {
                        return new NotFoundViewResult("BancaNotFound");
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
                return new NotFoundViewResult("BancaNotFound");
            }

            var product = await this.bancaRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return new NotFoundViewResult("BancaNotFound");
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
        public IActionResult BancaNotFound()
        {
            return this.View();
        }
    }
}
