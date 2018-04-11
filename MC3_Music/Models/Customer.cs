using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MC3_Music.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}