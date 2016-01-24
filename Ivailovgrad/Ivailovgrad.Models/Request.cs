namespace Ivailovgrad.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Contracts;

    public class Request
    {
        private DateTime _timeOfMakingRequest;

        public Request(DateTime time)
        {
            this._timeOfMakingRequest = time;
        }

        public int Id { get; set; }

        public DateTime TimeOfMakingRequest { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Adress Adress { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public IAdministrator Administrator { get; set; }

        public int CartId { get; set; }
        public ICart Cart { get; set; }

    }
}
