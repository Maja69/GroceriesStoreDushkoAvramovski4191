using GroceriesStore.Models;
using GroceriesStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.Controllers
{
    public class GroceriesController : Controller 
    {
        private readonly IGroceriesRepository _groceriesRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GroceriesController(IGroceriesRepository groceriesRepository, ICategoryRepository categoryRepository)
        {
            _groceriesRepository = groceriesRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List (string category)
        {
            IEnumerable<Groceries> groceries;
            string currentCategory;

            if(string.IsNullOrEmpty(category)) 
            {
                groceries = _groceriesRepository.GetAllGroceries.OrderBy(c => c.GroceriesId);
                currentCategory = "All Groceries";
            }
            else
            {
                
                groceries = _groceriesRepository.GetAllGroceries.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;

            }

            return View(new GroceriesListViewModel
            {
                Groceries = groceries,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var Groceries = _categoryRepository.GetGroceriesById(id);
            if (Groceries == null)
                return NotFound();
            return View(Groceries);
        }

        
    }
}
