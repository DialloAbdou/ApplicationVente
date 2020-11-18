using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVente.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<Categorie>().HasData(
               new Categorie { CategorieId = 1, NomCateg = "Legume", Description = "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère." }
            );
            model.Entity<Categorie>().HasData(
                               new Categorie { CategorieId = 2, NomCateg = "Fruit", Description = "un fruit est un aliment végétal, à la saveur sucrée, généralement Consommer cru" }
             );
            model.Entity<Categorie>().HasData(
                  new Categorie { CategorieId = 3, NomCateg = "Feculent", Description = "Les féculents sont des aliments d'origine végétale, constitués dans une forte proportion d'amidon" }
             );

            model.Entity<Produit>().HasData(
                    new Produit
                    {
                        ProduitId = 1,
                        NomProduit = "Tomate",
                        PrixVentHT = 1.5,
                        Tva = 0.5,
                        PrixVenteTTC = 1.15,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/89/Tomato_je.jpg",
                        CategorieId = 1,
                    }
                );

            model.Entity<Produit>().HasData(
                new Produit
                {
                    ProduitId = 2,
                    NomProduit = "Aubergine",
                    PrixVentHT = 2.1,
                    Tva = 0.05,
                    PrixVenteTTC = 2.20,
                    ImageUrl = "https://img-3.journaldesfemmes.fr/Mo420MV8Zpmp5eNwcSbyQUnUyzE=/910x607/smart/28d9e85a82b44ae2bf9cae050b62f938/ccmcms-jdf/10658977.jpg",
                    CategorieId = 1,

                }
                );
            model.Entity<Produit>().HasData(
                    new Produit
                    {
                        ProduitId = 3,
                        NomProduit = "Carotte",
                        PrixVentHT = 1.1,
                        Tva = 0.05,
                        PrixVenteTTC = 1.15,
                        ImageUrl = "https://img-3.journaldesfemmes.fr/4PYoBAo1J5rsDbuMiSTNRGolvhc=/910x607/smart/3b81125b1cbd46f7af87766bb8430152/ccmcms-jdf/10659145.jpg",
                        CategorieId = 1,
                    }
                );
            model.Entity<Produit>().HasData(
                 new Produit
                 {
                     ProduitId = 4,
                     NomProduit = "Pomme",
                     PrixVentHT = 2,
                     Tva = 0.05,
                     PrixVenteTTC = 2.05,
                     ImageUrl = "https://media.gerbeaud.net/2017/01/640/pomme-detouree.jpg",
                     CategorieId = 2,
                 }
                );
            model.Entity<Produit>().HasData(
                new Produit
                {
                    ProduitId = 5,
                    NomProduit = "Orange",
                    PrixVentHT = 2,
                    Tva = 0.05,
                    PrixVenteTTC = 2.05,
                    ImageUrl = "https://produits.bienmanger.com/38345-0w0h0_Oranges_Navelate_Bio.jpg",
                    CategorieId = 2
                }
              );

            model.Entity<Produit>().HasData(
                        new Produit
                        {
                            ProduitId =6,
                            NomProduit = "Pain maison",
                            PrixVentHT = 1,
                            Tva = 0.05,
                            PrixVenteTTC = 1.05,
                            ImageUrl = "https://www.lesfousdeterroirs.fr/storage/images/wishlists/img/pain-maison-Mxd1y.jpeg",
                            CategorieId = 3
                        }
                );
        }

    }
}
