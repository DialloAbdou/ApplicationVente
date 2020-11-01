using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.Repository
{
    public interface IProduitRepository
    {
        public IEnumerable<Produit> GetAllProduits();
        public Produit GetProduit(int id);
    }
}
