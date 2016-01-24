namespace Ivailovgrad.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using Ivailovgrad.Models;
    using Microsoft.AspNet.Identity;
    using Models.BindingModels;

    public class AddressController : BaseController
    {
        [Authorize]
        public ActionResult CreateAddress(AdressCreationBindingModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("The adress can not be null!");
            }

            if (!ModelState.IsValid)
            {
                throw new ArgumentException("The inputed address is not corect!");
            }

            var user = this.Context.Users.Find(this.User.Identity.GetUserId());
            Adress adress = new Adress(
                model.City,
                model.Street,
                model.StreetNumber,
                model.BlockNumber,
                model.PostCode
                );

            this.Context.Adresses.Add(adress);

            user.Adress = adress;

            this.Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}