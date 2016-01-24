namespace Ivailovgrad.Models.Contracts
{
    using System.Collections.Generic;

    public interface ICart
    {
        int Id { get; set; }

        ICollection<IItem> ItemsCollection { get; set; }

        IDictionary<IItem, int> Items { get; }
    }
}
