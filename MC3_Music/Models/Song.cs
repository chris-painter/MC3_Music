using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MC3_Music.Models
{
    public class Song
    {
        public int Id { get; set; }
        public Album album { get; set; }
        public string SongTitle { get; set; }
    }
}