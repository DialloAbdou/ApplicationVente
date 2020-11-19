using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationVente.Models;
using WebApplicationVente.Repository;

namespace WebApplicationVente.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
                
        }
        [HttpGet]
        public IActionResult CreateOrder()    
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateOrder(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.shoppingCartItems = items;
            if(_shoppingCart.shoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your Cart is empty Add your Produit");
            }
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.clearCart();
                return RedirectToAction("ConfirmOrder");
            }
            return View(order);
        }

        public IActionResult ConfirmOrder()
        {
            return View();
        }
       



    }
}