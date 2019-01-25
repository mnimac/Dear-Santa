﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DearSanta.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }
        public Gift Gift { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

    }
}
