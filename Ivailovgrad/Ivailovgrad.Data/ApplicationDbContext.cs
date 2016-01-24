namespace Ivailovgrad.Data
{
    using System.Data.Entity;
    using Ivailowgrad.Data;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;
    using Models;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("Page", throwIfV1Schema: false)
        {
            Database.SetInitializer(
                     new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public IDbSet<Adress> Adresses { get; set; }

        public IDbSet<AllProducts> AllProductses { get; set; }

        public IDbSet<Cart> Carts { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Item> Items { get; set; }

        public IDbSet<Request> Requests { get; set; }

        public IDbSet<Store> Stores { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
