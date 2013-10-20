using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSolution.Models;
using PagedList;


namespace SchoolSolution.Controllers
{
    public class CourseController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /Course/

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.DepartmentSortParm = String.IsNullOrEmpty(sortOrder) ? "Department desc" : "";
            ViewBag.NumberSortParm = sortOrder == "Number" ? "Number desc" : "Number";
            ViewBag.NameSortParm = sortOrder == "Name" ? "Name desc" : "Name";

            var courses = from s in db.Courses
                          select s;

            if (searchString != null)
            {
                page = 1;
            }

            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                int num = -1;
                int outputNum;
                bool isSearchStringNumber = Int32.TryParse(searchString, out outputNum);
                if (isSearchStringNumber)
                    num = outputNum;

                courses = courses.Where(s => s.Department.ToUpper().Contains(searchString.ToUpper())
                                       || s.Number.Equals(num)
                                       || s.Name.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "Department desc":
                    courses = courses.OrderByDescending(s => s.Department);
                    break;
                case "Number":
                    courses = courses.OrderBy(s => s.Number);
                    break;
                case "Number desc":
                    courses = courses.OrderByDescending(s => s.Number);
                    break;
                case "Name":
                    courses = courses.OrderBy(s => s.Name);
                    break;
                case "Name desc":
                    courses = courses.OrderByDescending(s => s.Name);
                    break;
                default:
                    courses = courses.OrderBy(s => s.Department);
                    break;
            }

            int pageSize = 4;
            int pageNumber = (page ?? 1);

            return View(courses.ToPagedList(pageNumber, pageSize));
        }

        //
        // GET: /Course/Details/5

        public ActionResult Details(int id)
        {
            var Course = db.Courses.Single(u => u.CourseId == id);

            if (Course == null)
            {
                return HttpNotFound();
            }

            return View(Course);
        }

        //
        // GET: /Course/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Course/Create

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
        // GET: /Course/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Course/Edit/5

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
        // GET: /Course/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Course/Delete/5

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
