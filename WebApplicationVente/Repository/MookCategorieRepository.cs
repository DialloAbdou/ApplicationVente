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
            return GetCategoriesAll().FirstOrDefault(c => c.Id == id);
          
        }
        public IEnumerable<Categorie> GetCategoriesAll()
        {
            return new List<Categorie>()
           {
               new Categorie{Id = 1, NomCateg = "Legume",Description = "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère."},
               new Categorie{Id = 2, NomCateg = "Legume",Description = "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère."},
               new Categorie{Id = 1, NomCateg = "Legume",Description = "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère."},
           };
        }
    }
}
