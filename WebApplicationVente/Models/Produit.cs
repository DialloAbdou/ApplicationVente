using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVente.Models
{
    public class Produit
    {
        [Key]
        public int ProduitId { get; set; }
        public string NomProduit { get; set; }
        public double PrixVentHT { get; set; }
        public double Tva { get; set; }
        public double PrixVenteTTC { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("Categorie")]
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }

    }
}
