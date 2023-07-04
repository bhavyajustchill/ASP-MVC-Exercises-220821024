using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bhavya_AllExercises.Controllers
{
    public class BhavyaController : Controller
    {
        // GET: Bhavya
        public ActionResult ExOne()
        {
            ViewBag.Name = "Bhavya Popat";
            return View();
        }

        public ActionResult ExTwo()
        {
            ViewBag.BgColor = "#00cc99";
            return View();
        }

        public ActionResult ExThree()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessForm(string colorValue)
        {
            ViewBag.BgColor = colorValue;
            return View("ExThree");
        }
    }
}