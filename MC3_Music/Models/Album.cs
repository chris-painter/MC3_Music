using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.ComponentModel.DataAnnotations;


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
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Image URL")]
        [Url]
        public string ImageURL { get; set; }

        public string Artist { get; set; }

        [Required]
        public string Genre { get; set; }

        public int Stock { get; set; }

        public double Price { get; set; }

        [Range(1,5)]
        public int Rating { get; set; }


    }
}