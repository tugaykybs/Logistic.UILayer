using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistic.UILayer.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult partialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
            {
            return PartialView();
        }
        public PartialViewResult PartiaFooter()
        {
            return PartiaFooter();
        }
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialSubscribe()
        {
            return PartialSubscribe();
        }
    }
}