using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.Models
{
    public interface IGroceriesRepository
    {
        IEnumerable<Groceries> GetAllGroceries { get; }
        IEnumerable<Groceries> GetGroceriesOnSale { get; }
        Groceries GetGroceriesById(int GroceriesId);
    }
}
