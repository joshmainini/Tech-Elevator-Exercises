using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.Web.Controllers;
using Validation.Web.Models;
using System.Web.Mvc;

namespace Validation.Web.Tests.Controllers
{
    [TestClass]
    public class UserControllerTests
    {
		[TestMethod()]
		public void Registration_Get()
		{
			UsersController controller = new UsersController();

			ViewResult result = controller.Registration() as ViewResult;

			Assert.IsNotNull(result);
			Assert.AreEqual("Registration", result.ViewName);
		}
		[TestMethod]
		public void Register_Post_Valid()
		{
			RegistrationViewModel model = new RegistrationViewModel();
			UsersController controller = new UsersController();

			ViewResult result = controller.Registration(model) as ViewResult;

			Assert.IsNotNull(result);
			Assert.AreEqual("Confirmation", result.ViewName);
		}
		[TestMethod]
		public void Login_Get()
		{
			UsersController controller = new UsersController();

			ViewResult result = controller.Login() as ViewResult;

			Assert.IsNotNull(result);
			Assert.AreEqual("Login", result.ViewName);
		}
		[TestMethod]
		public void Login_Post()
		{
			UsersController controller = new UsersController();

			LoginViewModel model = new LoginViewModel();
			ViewResult result = controller.Login(model) as ViewResult;

			Assert.IsNotNull(result);
			Assert.AreEqual("LoginConfirmation", result.ViewName);
		}
	}
}
