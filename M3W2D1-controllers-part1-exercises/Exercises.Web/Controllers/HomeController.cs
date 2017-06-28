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
		public ActionResult FizzBuzz()
		{
			return View("FizzBuzz");
		}
		public ActionResult FizzBuzzResult(FizzBuzzModel fizzModel)
		{
			return View("FizzBuzzResult", fizzModel);
		}
		public ActionResult LastTwo()
		{
			return View("LastTwo");
		}
		public ActionResult LastTwoResult(LastTwoModel model)
		{
			return View("LastTwoResult", model);
		}
		public ActionResult BabyLotto()
		{
			return View("BabyLotto");
		}
		public ActionResult BabyLottoResult(BabyLottoModel model)
		{
			return View("BabyLottoResult", model);
		}
		public ActionResult SquirrelCigarParty()
		{
			return View("SquirrelCigarParty");
		}
		public ActionResult SquirrelCigarPartyResult(SquirrelCigarPartyModel model)
		{
			return View("SquirrelCigarPartyResult",model);
		}
    }
}