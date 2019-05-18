namespace Lottery.Web.Data.Repositories
{
    using Entities;

    public class BancaRepository : GenericRepository<Banca>, IBancaRepository
    {
        public BancaRepository(DataContext context) : base(context)
        {
        }
    }
}
