using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.Repository
{
    public interface ICategorieRepository
    {
        public IEnumerable<Categorie> GetCategoriesAll();
        public Categorie GetCategorie(int id);
    }
}
