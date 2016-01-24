namespace Ivailovgrad.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Adress
    {
        public Adress(string city, string street, int streetNumber, int blockNumber, int postCode)
        {
            City = city;
            Street = street;
            StreetNumber = streetNumber;
            BlockNumber = blockNumber;
            PostCode = postCode;
        }

        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [MinLength(1, ErrorMessage = "The street name must contain more or one symbol")]
        public string  Street { get; set; }

        [Range(1, Int32.MaxValue)]
        public int StreetNumber { get; set; }

        [Range(0, Int32.MaxValue)]
        public int BlockNumber { get; set; }

        [Required]
        public int PostCode { get; set; }
    }
}
