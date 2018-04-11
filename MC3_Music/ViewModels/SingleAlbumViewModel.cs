using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MC3_Music.Models;

namespace MC3_Music.ViewModels
{
    public class SingleAlbumViewModel
    {
        public Album Album { get; set; }
        public List<Song> Songs { get; set; }
    }
}