using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MC3_Music.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public List<Album> ShoppingCart { get; set; }

    }
}