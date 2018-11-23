using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DearSanta.Models
{
    public interface IGiftRepository
    {
        IEnumerable<Gift> GetAllGifts();
        Gift GetGiftById(int giftId);
    }
}
