using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoskaWastes.Models
{
    public class Customer
    {
        public Customer()
        {
            OnVacation = false;
            HasPaid = false;
            IsWeekly = false;
        }
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [Display(Name = "Pickup Day")]
        public string PickupDay { get; set; }
        public bool OnVacation { get; set; }
        public bool HasPaid { get; set; }
        [Display(Name = "Weekly Pickups")]
        public bool IsWeekly { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}