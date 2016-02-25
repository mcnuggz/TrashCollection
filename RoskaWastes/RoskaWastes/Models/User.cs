using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoskaWastes.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string PickUpDay { get; set; }
        public bool PaidBil { get { return PaidBil; } set { value = false; } }
    }
}