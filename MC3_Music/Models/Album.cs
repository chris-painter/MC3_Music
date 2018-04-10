using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace MC3_Music.Models
{
    public class Album
    {
        public enum Genres
        {
            Country,
            HipHop,
            Rap,
            Rock,
            Classical
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public List<string> Songs { get; set; }
        //public Image CoverArt { get; set; }
        public Genres Genre { get; set; }
        public int Stock { get; set; }
        public int Rating { get; set; }
    }
}