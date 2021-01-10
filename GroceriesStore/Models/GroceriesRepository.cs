using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.Models
{
    public class GroceriesRepository : IGroceriesRepository
    {

        private readonly AppDbContext _appDbContext;
        public GroceriesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Groceries> GetAllGroceries
        {
           get
            {
                return _appDbContext.Groceries.Include(c => c.Category);
            }


        }

        public IEnumerable<Groceries> GetGroceriesOnSale
        {
            get
            {
                return _appDbContext.Groceries.Include(c => c.Category).Where(p => p.IsOnSale);
            }

        }
        public Groceries GetGroceriesById(int GroceriesId)
        {
            return _appDbContext.Groceries.FirstOrDefault(c => c.GroceriesId == GroceriesId);
        }
    }

}
