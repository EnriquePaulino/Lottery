namespace Lottery.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Dias.Any())
            {
                this.AddDia("Lunes");
                this.AddDia("Martes");
                this.AddDia("Miercoles");
                this.AddDia("Jueves");
                this.AddDia("Viernes");
                this.AddDia("Sabado");
                this.AddDia("Domingo");
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Frecuencias.Any())
            {
                this.AddFrecuencias("Diario");
                this.AddFrecuencias("Semanal");
                this.AddFrecuencias("Quincenal");
                this.AddFrecuencias("Mensual");
                this.AddFrecuencias("Anual");
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Zonas.Any())
            {
                this.AddZonas("Florida");
                this.AddZonas("New Jersey");
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Loterias.Any())
            {
                this.AddLoterias("New York (am)");
                this.AddLoterias("New Jersey (am)");
                this.AddLoterias("Florida (am)");
                this.AddLoterias("Super Pale Real");
                this.AddLoterias("Loteria Real (1:00 pm)");
                this.AddLoterias("Gana Mas (3:00 pm)");
                this.AddLoterias("New York (pm)");
                this.AddLoterias("Florida (pm)");
                this.AddLoterias("Super Pale Diario");
                this.AddLoterias("Quiniela Pale (Leidsa)");
                this.AddLoterias("Nacional (pm)");
                this.AddLoterias("New Jersey (pm)");
                this.AddLoterias("Connecticut (am)");
                this.AddLoterias("Connecticut (pm)");
                this.AddLoterias("Florida Pick2 (am)");
                this.AddLoterias("Florida Pick2 (pm)");
                this.AddLoterias("Loteka");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddDia(string name)
        {
            this.context.Dias.Add(new Dia
            {
                Name = name,
                IsAvailabe = true
            });
        }

        private void AddFrecuencias(string name)
        {
            this.context.Frecuencias.Add(new Frecuencia
            {
                Name = name,
                IsAvailabe = true
            });
        }

        private void AddZonas(string name)
        {
            this.context.Zonas.Add(new Zona
            {
                Name = name,
                IsAvailabe = true
            });
        }

        private void AddLoterias(string name)
        {
            this.context.Loterias.Add(new Loteria
            {
                Name = name,
                IsAvailabe = true
            });
        }
    }
}
