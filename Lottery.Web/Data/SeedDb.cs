﻿namespace Lottery.Web.Data
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

            if (!this.context.Lottery_Banks.Any())
            {
                this.AddBanks("Enrique", user);
                this.AddBanks("Paulino", user);
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Lottery_Owner.Any())
            {
                this.AddOwner("Farmacia Medicina", user);
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Lottery_Location.Any())
            {
                this.AddLocation("Florida", user);
                this.AddLocation("New Jersey", user);
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Lottery_Lottery.Any())
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
            this.context.Lottery_Banks.Add(new Banca
            {
                Name = name,
                Status = true,
                User = user
            });
        }

        private void AddOwner(string name, User user)
        {
            this.context.Lottery_Owner.Add(new Owner
            {
                Name = name,
                status = true
            });
        }

        private void AddLocation(string name, User user)
        {
            this.context.Lottery_Location.Add(new Location
            {
                Name = name,
                status = true
            });
        }

        private void AddLottery(string name)
        {
            this.context.Lottery_Lottery.Add(new Lottery
            {
                Name = name,
                IsAvailabe = true
            });
        }
    }
}
