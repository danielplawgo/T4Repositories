using Bogus;
using Bogus.DataSets;
using T4Repositories.Models;

namespace T4Repositories.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<T4Repositories.DataAccess.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(T4Repositories.DataAccess.DataContext context)
        {
            if (context.Users.Any() == false)
            {
                var users = new Faker<User>()
                    .RuleFor(u => u.UserName, (f, u) => f.Internet.UserName())
                    .Generate(10);

                foreach (var user in users)
                {
                    context.Users.AddOrUpdate(u => u.UserName, user);
                }
            }

            if (context.Products.Any() == false)
            {
                var users = new Faker<Product>()
                    .RuleFor(u => u.Name, (f, u) => f.Commerce.ProductName())
                    .Generate(10);

                foreach (var user in users)
                {
                    context.Products.AddOrUpdate(u => u.Name, user);
                }
            }
        }
    }
}
