using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DearSanta.Models
{
    public class GiftRepository : IGiftRepository
    {
        private readonly AppDbContext _appDbContext;

        public GiftRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Gift> GetAllGifts()
        {
            return _appDbContext.Gifts.OrderBy(g => g.Name);
        }

        public Gift GetGiftById(int giftId)
        {
            return _appDbContext.Gifts.FirstOrDefault(g => g.Id == giftId); 
        }
    }
}
