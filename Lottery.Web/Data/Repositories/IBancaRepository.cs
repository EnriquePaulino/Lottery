namespace Lottery.Web.Data.Repositories
{
    using Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBancaRepository : IGenericRepository<Banca>
    {
        IEnumerable<Banca> GetAllBancas();

        IEnumerable<Banca> AddBanca(Banca banca);

        Task<bool> SaveAllAsync(Banca banca);

        IEnumerable<SelectListItem> GetComboPropietarios();

        IEnumerable<SelectListItem> GetComboLocalidades();

        IEnumerable<SelectListItem> GetComboZonas();

        IEnumerable<SelectListItem> GetComboPaises();
    }
}
