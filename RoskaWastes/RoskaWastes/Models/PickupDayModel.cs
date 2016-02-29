using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoskaWastes.Models
{
    public class PickupDayModel
    {
        [Required]
        [Display(Name ="Pickup Day")]
        public string Day { get; set; }
        [Display(Name = "Set to Weekly Pickups?")]
        public bool IsWeekly { get; set; }

        public IEnumerable<SelectListItem> Days { get; set; }
    }
}