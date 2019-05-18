namespace Lottery.Web.Data
{    
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Helpers;
    using Microsoft.AspNetCore.Identity;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("paulinoenrique@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Enrique",
                    LastName = "Paulino",
                    Email = "paulinoenrique@gmail.com",
                    UserName = "paulinoenrique@gmail.com",
                    PhoneNumber = "(809) 710-5012"
                };

                var result = await this.userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!this.context.Bancas.Any())
            {
                this.AddBancas("Enrique", user);
                this.AddBancas("Paulino", user);
                await this.context.SaveChangesAsync();
            }

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

        private void AddBancas(string name, User user)
        {
            this.context.Bancas.Add(new Banca
            {
                Name = name,
                Monto = 10000,
                IsAvailabe = true,
                User = user
            });
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
