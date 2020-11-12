using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationVente.Repository;
using WebApplicationVente.ViewModels;

namespace WebApplicationVente.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduitRepository _produitRepository;
        public HomeController(IProduitRepository produitRepository )
        {
            _produitRepository = produitRepository;

        }
        public IActionResult Index()
        {
            var produitFarVM = new ProduitListViewModel();
             produitFarVM.Produits = _produitRepository.GetAllProduits().Take(3);
            return View(produitFarVM);
        }
    }
}