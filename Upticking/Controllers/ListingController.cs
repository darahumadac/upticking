using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Upticking.Controllers
{
    public class ListingController : Controller
    {
        //
        // GET: /Listing/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Listing/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Listing/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Listing/Create

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
        // GET: /Listing/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Listing/Edit/5

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
        // GET: /Listing/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Listing/Delete/5

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
