namespace Ivailovgrad.Web.Controllers
{
    using System.Web.Mvc;
    using Data;

    public class BaseController : Controller
    {
        protected ApplicationDbContext _contex;

        public BaseController()
        {
            this.Context = new ApplicationDbContext();
        }

        protected ApplicationDbContext Context { get; set; }
    }
}