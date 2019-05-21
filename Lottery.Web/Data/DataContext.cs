namespace Lottery.Web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Banca> Lottery_Banks { get; set; }

        public DbSet<Lottery> Lottery_Lottery { get; set; }

        public DbSet<Owner> Lottery_Owner { get; set; }

        public DbSet<Location> Lottery_Location { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
