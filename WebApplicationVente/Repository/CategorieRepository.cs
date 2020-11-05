using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.Repository
{
    public class CategorieRepository : ICategorieRepository
    {
        private readonly AppDbContext _appDbContext;

        /**
         *  Injection de dependance de DbConctext*
         */
        public CategorieRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;

        }
        public Categorie GetCategorie(int id)
        {
            return GetCategoriesAll().FirstOrDefault(c => c.CategorieId == id);
        }

        public IEnumerable<Categorie> GetCategoriesAll()
        {
            return _appDbContext.Categories;
        }
    }
}
