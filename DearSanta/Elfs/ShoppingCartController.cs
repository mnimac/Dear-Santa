using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DearSanta.Logic;
using DearSanta.Models;
using DearSanta.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace DearSanta.Elfs
{
    public class ShoppingCartController : Controller
    {
        private readonly IGiftRepository _giftRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IGiftRepository giftRepository, ShoppingCart shoppingCart)
        {
            _giftRepository = giftRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
        /*
            public RedirectToActionResult AddToShoppingCart(int giftId)
            {
          
            object selectedGift = _giftRepository.GetGiftById(giftId).FirstOrDefault(g => g.GiftId == giftId);

            if (selectedGift != null)
                {
                    _shoppingCart.AddToCart(selectedGift, 1);
                }
                return RedirectToAction("Index");
            }
        
            public RedirectToActionResult RemoveFromShoppingCart(int giftId)
            {
                var selectedGift = _giftRepository.Pies.FirstOrDefault(g => g.GiftId == giftId);

                if (selectedGift != null)
                {
                    _shoppingCart.RemoveFromCart(selectedGift);
                }
                return RedirectToAction("Index");
            }*/
    }
}
