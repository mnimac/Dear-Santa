using DearSanta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DearSanta.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Gift> Gifts { get; set; }
    }
}
