namespace Ivailovgrad.Models.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Ivailowgrad.Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CartTests
    {
        const int Items_Count = 10;
        public Cart cart;

        [TestInitialize]
        public void FillCartWithProducts()
        {
            this.cart = new Cart();

            FillCartCollectionWithItems(Items_Count);

            FillCartItemsAndQuantityWithData(this.cart.ItemsCollection);
        }

        [TestMethod]
        public void CalkPriceForAllPeacesFromSomeItem_Testing()
        {
            IItem item = this.cart.Items
                .Where(x => x.Key.Name == "Terlici")
                .Select(x => x.Key)
                .FirstOrDefault();
            decimal expectedResult = this.cart.CalkPriceForAllPeacesFromSomeItem("Terlici");
            int quntity;
            this.cart.Items.TryGetValue(item, out quntity);

            Assert.AreEqual(11  * quntity, expectedResult, "The method calk incorrect price of all pieces of last element!");
        }

        public void FillCartCollectionWithItems(int length)
        {
            for (int i = 0; i <= length; i++)
            {
                string curentItemName = ((ItemName) i).ToString();
                string curentItemDescription = ((ItemName) i).ToString() + "Mnogo qk description";
                string curentItemSize = ((ItemName) i).ToString() + "Size";
                Category category = new Category(i + string.Empty);
                IItem item = new Item(curentItemName,  i * 1.1m, curentItemDescription, curentItemSize, category);

                this.cart.ItemsCollection.Add(item);
            }
        }

        public void FillCartItemsAndQuantityWithData(ICollection<IItem> itemsCollection)
        {
            var itemsAsArray = itemsCollection.ToArray();
            for (int i = 0; i < itemsCollection.Count; i++)
            {
                IItem item = itemsAsArray[i];
                this.cart.Items.Add(item, i + 1);
            }
        }
    }
}
