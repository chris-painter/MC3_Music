using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MC3_Music.Models;

namespace MC3_Music.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Album> Albums { get; set; }
        public Customer Customer { get; set; }
        public List<Cart> Cart { get; set; }
    }
}