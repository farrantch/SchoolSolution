using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSolution.Models;

namespace SchoolSolution.Controllers
{
    public class LibraryController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /Library/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            LibraryItem li = db.LibraryItems.Single(u => u.LibraryItemID == id);

            if (User == null)
                return HttpNotFound();

            ViewBag.Class = li.GetType();
            return View(li);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        public void CheckoutLibraryItem(LibraryItem libraryItem, UserProfile user)
        {

        }

        public void ReturnLibraryItem(LibraryItem libraryItem)
        {

        }
    }
}
