namespace Ivailovgrad.Web.Models.BindingModels
{
    public class AdressCreationBindingModel
    {
        public AdressCreationBindingModel()
        {
            
        }

        public AdressCreationBindingModel(string city, string street, int streetNumber, int blockNumber, int postCode)
        {
            City = city;
            Street = street;
            StreetNumber = streetNumber;
            BlockNumber = blockNumber;
            PostCode = postCode;
        }

        public string City { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public int BlockNumber { get; set; }

        public int PostCode { get; set; }
    }
}