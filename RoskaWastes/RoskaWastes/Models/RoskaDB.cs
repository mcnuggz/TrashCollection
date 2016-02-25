using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RoskaWastes.Models
{
    public class RoskaDB : DbContext
    {
        public RoskaDB() : base("DefaultConnection")
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}