using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVente.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string NomCateg { get; set; }
        public string Description { get; set; }
        public List<Produit> Produits { get; set; }


    }
}
