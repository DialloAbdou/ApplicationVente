using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVente.Models;

namespace WebApplicationVente.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly AppDbContext _appDbContext;

        public OrderRepository(ShoppingCart shoppingCart, AppDbContext appDbContext )
        {
            _shoppingCart = shoppingCart;
            _appDbContext = appDbContext;
        }



        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            var items = _shoppingCart.GetShoppingCartItems();
            order.OrderTotal = _shoppingCart.GetShoppinCartTotal();
            order.OrderDetails = new List<OrderDetail>();
            foreach(var item in items)
            {
                var orderDetail = new OrderDetail
                {
                    ProduitId = item.Prouit.ProduitId,
                    Amount = item.Amount,
                    Price = item.Prouit.PrixVenteTTC
                    
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
           
        }
    }
}
