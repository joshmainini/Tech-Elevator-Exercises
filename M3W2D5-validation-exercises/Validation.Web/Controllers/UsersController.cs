using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Web.Models;

namespace Validation.Web.Controllers
{
	public class UsersController : Controller
	{
		// GET: User
		public ActionResult Index()
		{
			return View("Index");
		}
		public ActionResult Registration()
		{
			return View("Registration");
		}
		[HttpPost]
		public ActionResult Registration(RegistrationViewModel model)
		{
			return View("Confirmation");
		}
		public ActionResult Login()
		{
			return View("Login");
		}
		[HttpPost]
		public ActionResult Login(LoginViewModel model)
		{
			return View("LoginConfirmation");
		}
	}
}