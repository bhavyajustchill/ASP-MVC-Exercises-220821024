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

        public ActionResult ExSix(string lengthValue)
        {
            ViewBag.Length = Convert.ToInt32(lengthValue);
            return View("ExSix");
        }
            
        public ActionResult ExSeven()
        {
            //Guid g = Guid.NewGuid();
            //string GuidString = g.ToString().ToLower().Substring(0, 6);
            //if (dynamicInputs == null)
            //{
            //    dynamicInputs = new List<string>();
            //}   
            ViewBag.DynamicFieldCount = 1;
            return View();
        }

        [HttpPost]
        public ActionResult GenerateFields()
        {
            var dynamicFields = ViewBag.DynamicFieldCount;
            ViewBag.Data = string.Join(",", dynamicFields ?? new string[] { });

            if (dynamicFields != null)
            {
                ViewBag.DynamicFieldCount = dynamicFields.Length + 1; // Increment the field count
            }
            else
            {
                ViewBag.DynamicFieldCount = 1; // Set initial field count
            }

            return RedirectToAction("ExSeven");
        }

    }
}