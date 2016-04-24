namespace WebApplication1.Controllers
{
    using App.Data.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using App.Business.Logic;

    public class RegionController : Controller
    {
        // GET: Region
        public ActionResult Index()
        {
            var result = new RegionBusinessLogic().Load();

            return View(result);
        }
    }
}