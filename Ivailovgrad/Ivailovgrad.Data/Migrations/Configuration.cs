namespace Ivailovgrad.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.

            //var adres = new Adress("Kardzhali", "P.K.Yavorov", 12, 0, 6600);
            //var user = new User
            //{
            //    UserName = "k.yankov1980@gmail.com",
            //    Email = "k.yankov1980@gmail.com",
            //    FirstName = "Kiril",
            //    LatsName = "Yankov",
            //    PhoneNumber = "0885759229",
            //    Adress = adres
            //};

            //context.Users.AddOrUpdate(user);
            //context.Adresses.AddOrUpdate(adres);
        }
    }
}
