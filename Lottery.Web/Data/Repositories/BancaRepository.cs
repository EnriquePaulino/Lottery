namespace Lottery.Web.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    public class BancaRepository : GenericRepository<Banca>, IBancaRepository
    {
        private readonly DataContext context;

        public BancaRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public Banca GetBanca(int id)
        {
            return this.context.Lottery_Banca.Find(id);
        }

        public IEnumerable<Banca> GetAllBancas()
        {
            return context.Lottery_Banca.OrderBy(p => p.Descripcion);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public IEnumerable<Banca> AddBanca(Banca banca)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsync(Banca banca)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetComboPropietarios()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetComboLocalidades()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetComboZonas()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetComboPaises()
        {
            throw new System.NotImplementedException();
        }



        //public IQueryable GetAllWithUsers()
        //{
        //    return this.context.Lottery_Banca.Include(p => p.User);
        //}

        //public IEnumerable<SelectListItem> GetComboPropietarios()
        //{
        //    var list = this.context.Lottery_Propietario.Select(o => new SelectListItem
        //    {
        //        Text = o.Nombre,
        //        Value = o.Id.ToString()
        //    }).OrderBy(o => o.Text).ToList();

        //    list.Insert(0, new SelectListItem
        //    {
        //        Text = "Seleccione el propietario...",
        //        Value = "0"
        //    });

        //    return list;
        //}

        //public IEnumerable<SelectListItem> GetComboLocalidades()
        //{
        //    var list = this.context.Lottery_Localidad.Select(l => new SelectListItem
        //    {
        //        Text = l.Descripcion,
        //        Value = l.Id.ToString()
        //    }).OrderBy(l => l.Text).ToList();

        //    list.Insert(0, new SelectListItem
        //    {
        //        Text = "Seleccione la localidad...",
        //        Value = "0"
        //    });

        //    return list;
        //}

        //public IEnumerable<SelectListItem> GetComboZonas()
        //{
        //    var list = this.context.Lottery_Zona.Select(l => new SelectListItem
        //    {
        //        Text = l.Descripcion,
        //        Value = l.Id.ToString()
        //    }).OrderBy(l => l.Text).ToList();

        //    list.Insert(0, new SelectListItem
        //    {
        //        Text = "Seleccione la zona...",
        //        Value = "0"
        //    });

        //    return list;
        //}

        //public IEnumerable<SelectListItem> GetComboPaises()
        //{
        //    var list = this.context.Lottery_Pais.Select(l => new SelectListItem
        //    {
        //        Text = l.Descripcion,
        //        Value = l.Id.ToString()
        //    }).OrderBy(l => l.Text).ToList();

        //    list.Insert(0, new SelectListItem
        //    {
        //        Text = "Seleccione la pais...",
        //        Value = "0"
        //    });

        //    return list;
        //}
    }
}
