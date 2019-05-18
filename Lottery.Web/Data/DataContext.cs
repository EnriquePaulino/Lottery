namespace Lottery.Web.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {
        public DbSet<Banca> Bancas { get; set; }

        public DbSet<Dia> Dias { get; set; }

        public DbSet<Frecuencia> Frecuencias { get; set; }

        public DbSet<Gasto> Gastos { get; set; }

        public DbSet<GastoDetalle> GastoDetalles { get; set; }

        public DbSet<Horario> Horarios { get; set; }

        public DbSet<Localidad> Localidades { get; set; }

        public DbSet<Loteria> Loterias { get; set; }

        public DbSet<Precio> Precios { get; set; }

        public DbSet<Propietario> Propietarios { get; set; }

        public DbSet<Zona> Zonas { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
