using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DearSanta.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace DearSanta.Elfs
{
    [Authorize]
    public class WishController : Controller
    {        
        private readonly IWishRepository _wishRepository;

        public WishController(IWishRepository wishRepository)
        {
            _wishRepository = wishRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Wish wish)
        {
            if (ModelState.IsValid)
            {
                _wishRepository.AddWish(wish);
                return RedirectToAction("WishCompleted");
            }
            return View(wish);
        }

        public IActionResult WishCompleted()
        {
            return View();
        }
    }
}
