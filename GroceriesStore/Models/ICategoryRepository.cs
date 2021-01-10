using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }

        object GetGroceriesById(int id);
    }
}
