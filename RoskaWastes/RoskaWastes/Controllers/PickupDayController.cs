using RoskaWastes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoskaWastes.Controllers
{
    public class PickupDayController : Controller
    {
        [HttpGet]
        public ActionResult ChangePickupDay()
        {
            var days = GetAllDays();
            var model = new PickupDayModel();
            model.Days = GetSelectListItems(days);
            return View(model);
        }

        [HttpPost]
        public ActionResult ChangePickupDay(PickupDayModel model)
        {
            var days = GetAllDays();
            model.Days = GetSelectListItems(days);
            if (ModelState.IsValid)
            {
                Session["PickupDayModel"] = model;
                return RedirectToAction("Done");
            }
            return View("ChangeDay", model);
        }

        public ActionResult Done()
        {
            var model = Session["PickupDayModel"] as PickupDayModel;
            return View(model);
        }

        private IEnumerable<string> GetAllDays()
        {
            return new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday"
            };
        }

        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }
            return selectList;
        }
    }
}
