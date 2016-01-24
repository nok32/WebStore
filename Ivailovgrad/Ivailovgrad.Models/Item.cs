namespace Ivailovgrad.Models
{
    using Contracts;
    using Ivailowgrad.Data.Contracts;

    public class Item : IItem
    {
        private string _name;
        private IImage _img;
        private decimal _price;
        private string _description;
        private string _size;
        private ICategory _category;

        public Item(string name, decimal price, string description, string size, ICategory category, IImage img = null)
        {
            this.Name = name;
            this.Img = img;
            this.Price = price;
            this.Description = description;
            this.Size = size;
            this.Category = category;
        }

        public int Id { get; set; }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
            
        }

        public IImage Img
        {
            get { return this._img; }
            set { this._img = value; }
        }

        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        public string Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        public int CategoryId { get; set; }
        public ICategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

    }
}
