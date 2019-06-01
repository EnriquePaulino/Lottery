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

            if (!this.context.Lottery_Banca.Any())
            {
                this.AddBanks("Enrique", user);
                this.AddBanks("Paulino", user);
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Lottery_Propietario.Any())
            {
                this.AddPropietario("Farmacia Medicina", user);
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Lottery_Zona.Any())
            {
                this.AddZona("Florida");
                this.AddZona("New Jersey");
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Lottery_Loteria.Any())
            {
                this.AddLottery("New York (am)");
                this.AddLottery("New Jersey (am)");
                this.AddLottery("Florida (am)");
                this.AddLottery("Super Pale Real");
                this.AddLottery("Loteria Real (1:00 pm)");
                this.AddLottery("Gana Mas (3:00 pm)");
                this.AddLottery("New York (pm)");
                this.AddLottery("Florida (pm)");
                this.AddLottery("Super Pale Diario");
                this.AddLottery("Quiniela Pale (Leidsa)");
                this.AddLottery("Nacional (pm)");
                this.AddLottery("New Jersey (pm)");
                this.AddLottery("Connecticut (am)");
                this.AddLottery("Connecticut (pm)");
                this.AddLottery("Florida Pick2 (am)");
                this.AddLottery("Florida Pick2 (pm)");
                this.AddLottery("Loteka");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddBanks(string name, User user)
        {
            this.context.Lottery_Banca.Add(new Banca
            {
                Descripcion = name,
                Status = true,
                User = user
            });
        }

        private void AddPropietario(string name, User user)
        {
            this.context.Lottery_Propietario.Add(new Propietario
            {
                Nombre = name,
                status = true
            });
        }

        private void AddZona(string name)
        {
            this.context.Lottery_Zona.Add(new Zona
            {
                Descripcion = name,
                status = true
            });
        }

        private void AddLottery(string name)
        {
            this.context.Lottery_Loteria.Add(new Loteria
            {
                Descripcion = name,
                status = true
            });
        }
    }
}
