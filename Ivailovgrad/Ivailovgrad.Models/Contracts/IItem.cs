namespace Ivailovgrad.Models.Contracts
{
    using Ivailowgrad.Data.Contracts;

    public interface IItem
    {
        string Name { get; }
        IImage Img { get; }
        decimal Price { get; }
        string Description { get; }
        string Size { get; }
        ICategory Category { get; set; }
    }
}
