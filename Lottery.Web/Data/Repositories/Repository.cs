namespace Lottery.Web.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Banca> GetBancas()
        {
            return this.context.Bancas.OrderBy(p => p.Name);
        }

        public Banca GetBanca(int id)
        {
            return this.context.Bancas.Find(id);
        }

        public void AddBanca(Banca banca)
        {
            this.context.Bancas.Add(banca);
        }

        public void UpdateBanca(Banca banca)
        {
            this.context.Bancas.Update(banca);
        }

        public void RemoveBanca(Banca banca)
        {
            this.context.Bancas.Remove(banca);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool BancaExists(int id)
        {
            return this.context.Bancas.Any(p => p.Id == id);
        }
    }
}
