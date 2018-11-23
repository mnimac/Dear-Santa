using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DearSanta.Models;
using DearSanta.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace DearSanta.Elfs
{
    public class HomeController : Controller
    {
        private readonly IGiftRepository _giftRepository;

        public HomeController(IGiftRepository giftRepository)
        {
            _giftRepository = giftRepository;
        }

        public IActionResult Index()
        {
            

            var gifts = _giftRepository.GetAllGifts();

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Santas Workshop!",
                Gifts = gifts.ToList()
            };

            return View(homeViewModel);
        }
    }
}
