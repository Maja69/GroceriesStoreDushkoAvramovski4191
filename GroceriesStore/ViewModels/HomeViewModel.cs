using GroceriesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Groceries> GroceriesOnSale { get; set; }
    }
}
