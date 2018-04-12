using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace MC3_Music.Models
{
    public class Album
    {
        //public enum Genres
        //{
        //    Country,
        //    HipHop,
        //    Rap,
        //    Rock,
        //    Classical
        //}
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        //public DateTime DateReleased { get; set; }
        public int Rating { get; set; }
    }
}