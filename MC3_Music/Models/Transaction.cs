using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace MC3_Music.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int Album_Id { get; set; }
        [ForeignKey("Album_Id")]
        public Album Album { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Price { get; set; }


        //public double Price
        //{
        //    get
        //    {
        //        return price;
        //    }
        //    set
        //    {
        //        price = Album.Price;
        //    }
        //}
        
    }
}