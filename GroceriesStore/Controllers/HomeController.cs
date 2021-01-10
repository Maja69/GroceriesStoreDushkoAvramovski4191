using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceriesStore.Models;
using GroceriesStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GroceriesStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGroceriesRepository _groceriesRepository;

        public HomeController(IGroceriesRepository groceriesRepository)
        {
            _groceriesRepository = groceriesRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                GroceriesOnSale = _groceriesRepository.GetGroceriesOnSale
            };
            return View(homeViewModel);
        }
    }
}
