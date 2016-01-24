namespace Ivailovgrad.Models
{
    using System.Collections.Generic;

    public class AllProducts
    {
        public int Id { get; set; }
        public static Dictionary<string, int> Products { get; set; }
    }
}
