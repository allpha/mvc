using App.Business.Logic;
using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var result = new RegionBusinessLogic().Load();

            return View(result);
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            var result = new RegionBusinessLogic().Load().Select(a => a).Where(a => a.Id == id).FirstOrDefault();

            return View(result);
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            var NewItem = new Region();

            return View(NewItem);
        }

        // POST: Test/Create
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

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            var result = new RegionBusinessLogic().Load().Select(a=>a).Where(a=>a.Id == id).FirstOrDefault();

            return View(result);
        }

        // POST: Test/Edit/5
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

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
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
