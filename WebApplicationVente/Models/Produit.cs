using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVente.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string NomProduit { get; set; }
        public double PrixVentHT { get; set; }
        public double Tva { get; set; }
        public double PrixVenteTTC { get; set; }
        public string ImageUrl { get; set; }
        public int CategorieId { get; set; }
        public Categorie categorie { get; set; }



    }
}
