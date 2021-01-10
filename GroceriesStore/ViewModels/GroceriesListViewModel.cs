using GroceriesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.ViewModels
{
    public class GroceriesListViewModel
    {
        public IEnumerable<Groceries> Groceries { get; set; }
        public string CurrentCategory { get; set; }

    }
}
