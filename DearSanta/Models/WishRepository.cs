using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DearSanta.Models
{
    public class WishRepository : IWishRepository
    {
        private readonly AppDbContext _appDbContext;

        public WishRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddWish(Wish wish)
        {
            _appDbContext.Wishes.Add(wish);
            _appDbContext.SaveChanges();
        }
    }
}
