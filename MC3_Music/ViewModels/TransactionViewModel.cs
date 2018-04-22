using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MC3_Music.Models;

namespace MC3_Music.ViewModels
{
    public class TransactionViewModel
    {
        public List<Transaction> Transactions { get; set; }
        public List<Album> Albums { get; set; }
       // public List<Year> Years { get; set; }
    }
}