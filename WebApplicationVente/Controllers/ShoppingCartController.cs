using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationVente.Models;
using WebApplicationVente.Repository;
using WebApplicationVente.ViewModels;

namespace WebApplicationVente.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IProduitRepository _produitRepository;
        public ShoppingCartController(ShoppingCart shoppingCart, IProduitRepository produitRepository)
        {
            _shoppingCart = shoppingCart;
            _produitRepository = produitRepository;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.shoppingCartItems = items;
            var shoppingcartViewModel = new ShoppingCartViewModel();
            shoppingcartViewModel.ShoppingCart = _shoppingCart;
            shoppingcartViewModel.ShoppingCartTotal = _shoppingCart.GetShoppinCartTotal();
            return View(shoppingcartViewModel);
        }
        
        /*
         * Action pour ajouter des Porduits dans le panier
         * **/
        public IActionResult AddToShoppingCart(int prodId)
        {
            var produit = _produitRepository.GetProduit(prodId);
            if (produit != null)
                _shoppingCart.AddSoppingcart(produit, 1);

            return RedirectToAction("Index");
        }

        public IActionResult RemoveToShoppingCart(int prodId)
        {
            var produit = _produitRepository.GetProduit(prodId);
            if (produit != null)
                _shoppingCart.RemoveSoppinCart(produit);
            return RedirectToAction("Index");
        }
    }
}