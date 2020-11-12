using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVente.Models
{
    public class ShoppingCartItem
    {   [Key]
        public int ShoppingCartItemId { get; set; }
        public int Amount { get; set; }
        public Produit Prouit { get; set; }
        public string ShoppingCartSessionId { get; set; }
    }
}
