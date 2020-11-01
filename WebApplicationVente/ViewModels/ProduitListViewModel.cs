using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.ViewModels
{
    public class ProduitListViewModel
    {
        public IEnumerable<Produit> Produits { get; set; } // unse Liste Enumerable

    }
}
