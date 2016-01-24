namespace Ivailovgrad.Models
{
    using System.Collections.Generic;
    using Contracts;
    using Ivailowgrad.Data.Contracts;

    public class Store : IStore
    {
        private IStore _store;

        private Store()
        {
            this.Items = new HashSet<IItem>();
            this.ItemsQuantity = new Dictionary<IItem, int>();
        }

        public int Id { get; set; }

        public ICollection<IItem> Items { get; set; }

        public IDictionary<IItem, int> ItemsQuantity { get; set; }

        //Singalthon patthern
        /// <summary>
        ///  This is impolementations of "Singelthon pattren"
        /// </summary>
        /// <returns>IStore</returns>
        public IStore CreateStore()
        {
            if (this._store == null)
            {
                this._store = new Store();
            }

            return this._store;
        }
    }
}
