namespace Lottery.Web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Models;
    using Repositories;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IPaisRepository : IGenericRepository<Pais>
    {
        //IQueryable GetPaisesWithCiudades();

        //Task<Pais> GetPaisWithCiudadesAsync(int id);

        //Task<Ciudad> GetCiudadAsync(int id);

        //Task AddCiudadAsync(CiudadViewModel model);

        //Task<int> UpdateCiudadAsync(Ciudad ciudad);

        //Task<int> DeleteCiudadAsync(Ciudad ciudad);

        //IEnumerable<SelectListItem> GetComboPaises();

        //IEnumerable<SelectListItem> GetComboPaises(int paisId);

        //Task<Pais> GetPaisAsync(Ciudad ciudad);
    }
}
