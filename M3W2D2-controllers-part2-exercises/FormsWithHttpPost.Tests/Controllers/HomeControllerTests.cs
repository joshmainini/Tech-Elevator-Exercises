using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormsWithHttpPost.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsWithHttpPost.Models;
using FormsWithHttpPost.DAL;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
			HomeController controller = new HomeController();

			ViewResult result = controller.Index() as ViewResult;

			Assert.IsNotNull(result);
			Assert.AreEqual("Index", result.ViewName);
        }
		[TestMethod()]
		public void NextReview_ReturnsCorrectView()
		{
		
			HomeController controller = new HomeController();

			ViewResult result = controller.NextReview() as ViewResult;

			
			Assert.IsNotNull(result);
			Assert.AreEqual("NextReview", result.ViewName);
		}
	}
}