namespace Ivailovgrad.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Ivailowgrad.Data.Contracts;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {
        private ICollection<Request> _requests;
        private DateTime _timeOfCreationOfUsers;

        public User()
        {
            this._requests = new HashSet<Request>();
            this._timeOfCreationOfUsers = DateTime.Now;
        } 

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LatsName { get; set; }

        public IImage Img { get; set; }

        public Adress Adress { get; set; }

        public decimal Discount { get; set; }

        public bool HaveFirstItemAddedToCart { get; set; }

        public DateTime TimeOfCreationUser
        {
            get { return this._timeOfCreationOfUsers; }
        }

        public virtual ICollection<Request> Requests
        {
            get { return this._requests; }
            set { this._requests = value; }
        }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
