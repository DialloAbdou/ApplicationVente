﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.ViewModels
{
    public class ShoppingCartViewModel
    {
        public  ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }


    }
}
