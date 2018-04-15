using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MC3_Music.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Album Album { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}