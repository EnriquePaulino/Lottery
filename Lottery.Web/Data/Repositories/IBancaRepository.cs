namespace Lottery.Web.Data.Repositories
{
    using Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;

    public interface IBancaRepository : IGenericRepository<Banca>
    {
        IEnumerable<SelectListItem> GetComboPropietario();

        IEnumerable<SelectListItem> GetComboLocalidad();

        IEnumerable<SelectListItem> GetComboZona();
    }
}
