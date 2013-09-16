using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSolution.Models;

namespace SchoolSolution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.Country = new SelectList(Country.GetCountryList(), "Code", "Name");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetStates(string id = "")
        {
            var stateList = StateProvince.GetStates()
                .Where(s => s.CountryCode.ToLower() == id.ToLower());

            return this.Json(stateList, JsonRequestBehavior.AllowGet);
        }
    }
}
