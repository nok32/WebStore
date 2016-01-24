namespace Ivailovgrad.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public class Cart : ICart
    {
        private IDictionary<IItem, int> _items;
        private ICollection<IItem> _itemsCollection; 

        public Cart()
        {
            this.ItemsCollection = new HashSet<IItem>();
            this._items = new Dictionary<IItem, int>();
        }

        public int Id { get; set; }

        public virtual ICollection<IItem> ItemsCollection
        {
            get { return this._itemsCollection; }
            set { this._itemsCollection = value; }
        }

        public IDictionary<IItem, int> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        public decimal CalkPriceForAllPeacesFromSomeItem(string itemName)
        {
            decimal result = 0;

            var item = this.Items
                .Where(i => i.Key.Name == itemName)
                .Select(i => new
                {
                    Price = i.Key.Price,
                    Value = i.Value
                })
                .FirstOrDefault();

            result = item.Price * item.Value;

            return result;
        }

        public decimal CalkPriceOffAllProductsInCart()
        {
            decimal result = 0;

            foreach (var item in this.Items)
            {
                result += this.CalkPriceForAllPeacesFromSomeItem(item.Key.Name);
            }

            return result;
        }
    }
}
