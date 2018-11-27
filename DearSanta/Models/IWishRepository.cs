using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DearSanta.Models
{
    public interface IWishRepository
    {
        void AddWish(Wish wish);
    }
}
