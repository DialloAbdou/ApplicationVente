using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.Repository
{
    public class MookCategorieRepository : ICategorieRepository
    {
        public Categorie GetCategorie(int id)
        {
            return GetCategoriesAll().FirstOrDefault(c => c.CategorieId == id);
          
        }
        public IEnumerable<Categorie> GetCategoriesAll()
        {
            return new List<Categorie>()
           {
               new Categorie{CategorieId = 1, NomCateg = "Legume",Description = "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère."},
               new Categorie{CategorieId = 2, NomCateg = "Legume",Description = "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère."},
               new Categorie{CategorieId = 1, NomCateg = "Legume",Description = "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère."},
           };
        }
    }
}
