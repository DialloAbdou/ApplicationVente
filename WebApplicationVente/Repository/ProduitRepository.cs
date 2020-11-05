using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.Repository
{
    public class ProduitRepository : IProduitRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProduitRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;

        }

        public IEnumerable<Produit> GetAllProduits()
        {
            return _appDbContext.Produits.Include(c=>c.Categorie);
        }

        public Produit GetProduit(int id)
        {
            return GetAllProduits().FirstOrDefault(p =>p.ProduitId == id);
        }
    }
}
