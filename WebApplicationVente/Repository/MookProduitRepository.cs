using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.Repository
{
    public class MookProduitRepository : IProduitRepository
    {
        private readonly ICategorieRepository _category = new MookCategorieRepository();
        public IEnumerable<Produit> GetAllProduits()
        {
            return new List<Produit>()
            {
            new Produit{Id=1,NomProduit ="Tomate",PrixVentHT = 1.5, Tva= 0.5, PrixVenteTTC = 1.15,
            ImageUrl="https://upload.wikimedia.org/wikipedia/commons/8/89/Tomato_je.jpg", CategorieId = 1, categorie = _category.GetCategorie(1)},

            new Produit{Id=2,NomProduit ="Aubergine",PrixVentHT = 2.1, Tva= 0.05, PrixVenteTTC = 2.20,
            ImageUrl="https://img-3.journaldesfemmes.fr/Mo420MV8Zpmp5eNwcSbyQUnUyzE=/910x607/smart/28d9e85a82b44ae2bf9cae050b62f938/ccmcms-jdf/10658977.jpg", CategorieId = 1, categorie = _category.GetCategorie(1)},

            new Produit{Id=3,NomProduit ="Carotte",PrixVentHT = 1.1, Tva= 0.05, PrixVenteTTC = 1.15,
            ImageUrl="https://img-3.journaldesfemmes.fr/4PYoBAo1J5rsDbuMiSTNRGolvhc=/910x607/smart/3b81125b1cbd46f7af87766bb8430152/ccmcms-jdf/10659145.jpg", CategorieId = 1, categorie = _category.GetCategorie(1)},

            new Produit{Id=4,NomProduit ="Pomme",PrixVentHT = 2, Tva= 0.05, PrixVenteTTC = 2.05,
            ImageUrl="https://media.gerbeaud.net/2017/01/640/pomme-detouree.jpg", CategorieId = 2, categorie = _category.GetCategorie(2)},

            new Produit{Id=5,NomProduit ="Orange",PrixVentHT = 2, Tva= 0.05, PrixVenteTTC = 2.05,
            ImageUrl="https://produits.bienmanger.com/38345-0w0h0_Oranges_Navelate_Bio.jpg", CategorieId = 2, categorie = _category.GetCategorie(2)},

            new Produit{Id=5,NomProduit ="lait",PrixVentHT = 1, Tva= 0.05, PrixVenteTTC = 1.05,
            ImageUrl="https://www.carrefour.fr/media/1500x1500/Photosite/PGC/P.L.S./3270190021162_PHOTOSITE_20180223_161411_0.jpg?placeholder=1", CategorieId = 3, categorie = _category.GetCategorie(3)},



            };
        }

        public Produit GetProduit(int id)
        {
            return GetAllProduits().FirstOrDefault(p => p.Id == id);
        }
    }
}
