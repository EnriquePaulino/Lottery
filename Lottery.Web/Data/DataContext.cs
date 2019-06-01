namespace Lottery.Web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Banca> Lottery_Banca { get; set; }

        public DbSet<Loteria> Lottery_Loteria { get; set; }

        public DbSet<Propietario> Lottery_Propietario { get; set; }

        public DbSet<Localidad> Lottery_Localidad { get; set; }

        public DbSet<Premio> Lottery_Premio { get; set; }

        public DbSet<Zona> Lottery_Zona { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
