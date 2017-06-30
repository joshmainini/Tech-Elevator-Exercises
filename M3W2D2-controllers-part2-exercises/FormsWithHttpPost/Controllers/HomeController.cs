using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using FormsWithHttpPost.Models;
using FormsWithHttpPost.Models;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
		string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=productreview; Integrated Security = True";

		// GET: Home
		public ActionResult Index()
        {
            return View("Index");
        }
		public ActionResult NextReview()
		{
			return View("NextReview");
		}
		[HttpPost]
		public ActionResult NextReview(Review review)
		{
			ReviewSqlDAL dal = new ReviewSqlDAL(connectionString);
			dal.SaveReview(review);
			return RedirectToAction("Index");
		}
    }
}