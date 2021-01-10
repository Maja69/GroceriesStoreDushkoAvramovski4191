using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Groceries groceries, int amount)
        {
            var ShoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Groceries.GroceriesId == groceries.GroceriesId && s.ShoppingCartId == ShoppingCartId);
            if (ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Groceries = groceries,
                    Amount = amount
                };

                _appDbContext.ShoppingCartItems.Add(ShoppingCartItem);
            }
            else
            {
                ShoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFormCart(Groceries groceries)
        {
            var ShoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Groceries.GroceriesId == groceries.GroceriesId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if(ShoppingCartItem != null)
            {
                 if(ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;
                    localAmount = ShoppingCartItem.Amount;
                }
                 else
                {
                    _appDbContext.ShoppingCartItems.Remove(ShoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId) .Include (s => s.Groceries).ToList());
        }

        public void ClearCart()
        {
            var CartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(CartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Select(c => c.Groceries.Price * c.Amount).Sum();

            return total;
        }
    }
}
