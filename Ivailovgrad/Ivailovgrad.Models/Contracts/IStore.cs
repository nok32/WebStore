namespace Ivailowgrad.Data.Contracts
{
    using System.Collections.Generic;
    using Ivailovgrad.Models.Contracts;

    public interface IStore
    {
        ICollection<IItem> Items { get; set; }

        IDictionary<IItem, int> ItemsQuantity { get; set; }
    }
}
