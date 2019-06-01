namespace Lottery.Web.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
 
    public class BancaRepository : GenericRepository<Banca>, IBancaRepository
    {
        private readonly DataContext context;

        public BancaRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetComboPropietario()
        {
            var list = this.context.Lottery_Propietario.Select(o => new SelectListItem
            {
                Text = o.Nombre,
                Value = o.Id.ToString()
            }).OrderBy(o => o.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "Seleccione el propietario...",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboLocalidad()
        {
            var list = this.context.Lottery_Localidad.Select(l => new SelectListItem
            {
                Text = l.Descripcion,
                Value = l.Id.ToString()
            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "Seleccione la localidad...",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboZona()
        {
            var list = this.context.Lottery_Zona.Select(l => new SelectListItem
            {
                Text = l.Descripcion,
                Value = l.Id.ToString()
            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "Seleccione la zona...",
                Value = "0"
            });

            return list;
        }
    }
}
