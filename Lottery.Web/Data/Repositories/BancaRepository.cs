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

        public IEnumerable<SelectListItem> GetComboOwner()
        {
            var list = this.context.Lottery_Owner.Select(o => new SelectListItem
            {
                Text = o.Name,
                Value = o.Id.ToString()
            }).OrderBy(o => o.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a owner...)",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboLocation()
        {
            var list = this.context.Lottery_Location.Select(l => new SelectListItem
            {
                Text = l.Name,
                Value = l.Id.ToString()
            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a location...)",
                Value = "0"
            });

            return list;
        }
    }
}
