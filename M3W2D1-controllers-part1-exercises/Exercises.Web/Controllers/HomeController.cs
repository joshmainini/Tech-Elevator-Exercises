using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult OrderName()
		{
			return View("OrderName");
		}
		public ActionResult OrderNameResult(OrderNameModel model)
		{
			return View("OrderNameResult", model);
		}
		public ActionResult ColorizedName()
		{
			return View("ColorizedName");
		}
		public ActionResult ColorizedNameResult(ColorizedNameModel colorizedModel)
		{
			return View("ColorizedNameResult",colorizedModel);
		}
    }
}