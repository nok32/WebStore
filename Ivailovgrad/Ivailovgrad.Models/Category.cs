namespace Ivailowgrad.Data
{
    using System.Data.Entity.Migrations.Model;
    using Contracts;

    public class Category : ICategory
    {
        public int Id { get; set; }
        public Category(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
