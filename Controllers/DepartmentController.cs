using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSolution.Models;
using PagedList;

namespace SchoolSolution.Controllers
{
    public class DepartmentController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /Department/

        public ActionResult Index(int? page)
        {
            var Departments = from s in db.Departments
                              select s;
            int pageSize = 4;
            int pageNumber = (page ?? 1);

            return View(Departments.ToPagedList(pageNumber, pageSize));
        }

        //
        // GET: /Department/Details/5

        public ActionResult Details(string id)
        {
            var Department = db.Departments.Single(u => u.Abbreviation == id);

            if (Department == null)
            {
                return HttpNotFound();
            }

            return View(Department);
        }

        //
        // GET: /Department/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Department/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Department/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Department/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Department/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Department/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
