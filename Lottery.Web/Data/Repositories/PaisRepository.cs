namespace Lottery.Web.Data
{
    using Repositories;
    using Models;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class PaisRepository : GenericRepository<Pais>, IPaisRepository
    {
        private readonly DataContext context;

        public PaisRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        //public async Task AddCiudadAsync(CiudadViewModel model)
        //{
        //    var pais = await this.GetPaisWithCiudadesAsync(model.PaisId);
        //    if (pais == null)
        //    {
        //        return;
        //    }

        //    pais.Ciudades.Add(new Ciudad { Descripcion = model.Descripcion });
        //    this.context.Lottery_Pais.Update(pais);
        //    await this.context.SaveChangesAsync();
        //}

        //public async Task<int> DeleteCiudadAsync(Ciudad ciudad)
        //{
        //    var pais = await this.context.Lottery_Pais.Where(c => c.Ciudades.Any(ci => ci.Id == ciudad.Id)).FirstOrDefaultAsync();
        //    if (pais == null)
        //    {
        //        return 0;
        //    }

        //    this.context.Lottery_Ciudad.Remove(ciudad);
        //    await this.context.SaveChangesAsync();
        //    return pais.Id;
        //}

        //public IQueryable GetPaisesWithCiudades()
        //{
        //    return this.context.Lottery_Pais
        //        .Include(c => c.Ciudades)
        //        .OrderBy(c => c.Descripcion);
        //}

        //public async Task<Pais> GetPaisWithCiudadesAsync(int id)
        //{
        //    return await this.context.Lottery_Pais
        //        .Include(c => c.Ciudades)
        //        .Where(c => c.Id == id)
        //        .FirstOrDefaultAsync();
        //}

        //public async Task<int> UpdateCiudadAsync(Ciudad ciudad)
        //{
        //    var pais = await this.context.Lottery_Pais.Where(c => c.Ciudades.Any(ci => ci.Id == ciudad.Id)).FirstOrDefaultAsync();
        //    if (pais == null)
        //    {
        //        return 0;
        //    }

        //    this.context.Lottery_Ciudad.Update(ciudad);
        //    await this.context.SaveChangesAsync();
        //    return pais.Id;
        //}

        //public async Task<Ciudad> GetCiudadAsync(int id)
        //{
        //    return await this.context.Lottery_Ciudad.FindAsync(id);
        //}

        //public IEnumerable<SelectListItem> GetComboPaises()
        //{
        //    var list = this.context.Lottery_Pais.Select(c => new SelectListItem
        //    {
        //        Text = c.Descripcion,
        //        Value = c.Id.ToString()
        //    }).OrderBy(l => l.Text).ToList();

        //    list.Insert(0, new SelectListItem
        //    {
        //        Text = "(Select a pais...)",
        //        Value = "0"
        //    });

        //    return list;
        //}

        //public IEnumerable<SelectListItem> GetComboCiudades(int paisId)
        //{
        //    var pais = this.context.Lottery_Pais.Find(paisId);
        //    var list = new List<SelectListItem>();
        //    if (pais != null)
        //    {
        //        list = pais.Ciudades.Select(c => new SelectListItem
        //        {
        //            Text = c.Descripcion,
        //            Value = c.Id.ToString()
        //        }).OrderBy(l => l.Text).ToList();
        //    }

        //    list.Insert(0, new SelectListItem
        //    {
        //        Text = "(Select a ciudad...)",
        //        Value = "0"
        //    });

        //    return list;
        //}

        //public async Task<Pais> GetPaisAsync(Ciudad ciudad)
        //{
        //    return await this.context.Lottery_Pais
        //        .Where(c => c.Ciudades.Any(ci => ci.Id == ciudad.Id))
        //        .FirstOrDefaultAsync();
        //}

        //public IEnumerable<SelectListItem> GetComboPaises(int paisId)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
