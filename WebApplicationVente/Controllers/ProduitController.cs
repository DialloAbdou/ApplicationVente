using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationVente.Repository;
using WebApplicationVente.ViewModels;

namespace WebApplicationVente.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository _produitRepository;
        private readonly ICategorieRepository _categorieRepository;
        public ProduitController( IProduitRepository produitRepository, ICategorieRepository categorieRepository)
        {
            this._produitRepository = produitRepository;
            this._categorieRepository = categorieRepository;

        }
        public IActionResult List()
        {
            var prduitsViewModel = new ProduitListViewModel();
            prduitsViewModel.Produits = _produitRepository.GetAllProduits();
            return View(prduitsViewModel);
        }

        public IActionResult Detail(int idproduit)
        {
            var produit = _produitRepository.GetProduit(idproduit);
            if(produit==null)
                return NotFound();
            return View(produit);
        }
           
        
    }
}