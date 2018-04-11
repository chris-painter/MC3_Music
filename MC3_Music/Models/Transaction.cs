using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MC3_Music.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Customer customer { get; set; }
        public Album album { get; set; }
        public int quantity { get; set; }
        //datetime
    }
}