using GroceriesStore.Models;
using GroceriesStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.Controllers
{
    public class ShoppingCartController : Controller 
    {
        private readonly IGroceriesRepository _groceriesRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IGroceriesRepository groceriesRepository, ShoppingCart shoppingCart)
        {
            _groceriesRepository = groceriesRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int groceriesId)
        {
            var selectedGroceries = _groceriesRepository.GetAllGroceries.FirstOrDefault(c => c.GroceriesId == groceriesId);

            if (selectedGroceries != null)
            {
                _shoppingCart.AddToCart(selectedGroceries, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFormShoppingCart(int groceriesId)
        {
            var selectedGroceries = _groceriesRepository.GetAllGroceries.FirstOrDefault(c => c.GroceriesId == groceriesId);

            if (selectedGroceries != null)
            {
                _shoppingCart.RemoveFormCart(selectedGroceries);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
