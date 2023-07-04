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

        public ActionResult ExFour()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HideForm(string displayType)
        {
            ViewBag.Display = displayType;
            return View("ExFour");
        }

        public ActionResult ExFive()
        {
            string DefaultSize = "50";
            ViewBag.height = DefaultSize;
            ViewBag.width = DefaultSize;
            if (Request.Params["applySize"] == "Set")
            {
                string height = Request.Params["heightValue"];
                ViewBag.height = height;

                string width = Request.Params["widthValue"];
                ViewBag.width = width;
            }
            else if (Request.Params["applySize"] == "Reset")
            {
                ViewBag.height = DefaultSize;
                ViewBag.width = DefaultSize;
            }
            return View();
        }

        
    }
}