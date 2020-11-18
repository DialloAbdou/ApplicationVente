using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVente.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartSessionId { get; set; }
        public List<ShoppingCartItem> shoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        /*
         * * Creation Session de mon panier
         */
        public static ShoppingCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDbContext>();
            var sessionCart = session.GetString("cartIdSession") ?? Guid.NewGuid().ToString();
            session.SetString("cartIdSession", sessionCart);
            return new ShoppingCart(context) {ShoppingCartSessionId=sessionCart};
        }
       
        /*
         * Ajout du Produit dans le panier *
         */
        
        public void AddSoppingcart(Produit produit, int Amount)
        {
            var shoppinCartItem = _appDbContext.ShoppingCartItems.FirstOrDefault(item => item.ShoppingCartSessionId == ShoppingCartSessionId && item.Prouit.ProduitId == produit.ProduitId);
            if(shoppinCartItem == null)
            {
                shoppinCartItem = new ShoppingCartItem
                {
                    Prouit = produit,
                    ShoppingCartSessionId = ShoppingCartSessionId,
                    Amount = 1
                };  
             _appDbContext.ShoppingCartItems.Add(shoppinCartItem);
            }
            else
            {
                shoppinCartItem.Amount += 1;
            }
            _appDbContext.SaveChanges();

        }

        /*
         * Suppression du Produit dans le panier *
         */
        public int RemoveSoppinCart(Produit produit)
        {
            var shoppinCartItem = _appDbContext.ShoppingCartItems.FirstOrDefault(item => item.ShoppingCartSessionId == ShoppingCartSessionId && produit.ProduitId == item.Prouit.ProduitId);
            var localAmount = 0;
            if(shoppinCartItem !=null)
            {
                if (shoppinCartItem.Amount >0)
                {
                shoppinCartItem.Amount--;
                localAmount = shoppinCartItem.Amount;
                }else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppinCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;

        }
        /*
         * Liste de mes Paniers*
         */
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return shoppingCartItems ?? (shoppingCartItems= _appDbContext.ShoppingCartItems.Where(sp=>sp.ShoppingCartSessionId ==ShoppingCartSessionId).Include(s=>s.Prouit).ToList());
        }
        /*
         *  Vider les panier
         * **/
        public void clearCart()
        {
            var soppingCart = _appDbContext.ShoppingCartItems.Where(s => s.ShoppingCartSessionId == ShoppingCartSessionId);

             _appDbContext.ShoppingCartItems.RemoveRange(soppingCart);
             _appDbContext.SaveChanges();
        }

        /*
         * Total des produit dans le panier  *
         */
        public double GetShoppinCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(s => s.ShoppingCartSessionId == ShoppingCartSessionId)
                                .Select(c => c.Prouit.PrixVenteTTC * c.Amount).Sum();
            return total;
        }

    }
}
