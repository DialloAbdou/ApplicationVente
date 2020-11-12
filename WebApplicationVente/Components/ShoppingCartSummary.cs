using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;
using WebApplicationVente.ViewModels;

namespace WebApplicationVente.Components
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart; 
        }
        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            var shoppingcartViewModle = new ShoppingCartViewModel();

            shoppingcartViewModle.ShoppingCart = _shoppingCart;
            shoppingcartViewModle.ShoppingCart.shoppingCartItems = items;
            shoppingcartViewModle.ShoppingCartTotal = _shoppingCart.GetShoppinCartTotal();
            return View(shoppingcartViewModle);
        }
    }
}
