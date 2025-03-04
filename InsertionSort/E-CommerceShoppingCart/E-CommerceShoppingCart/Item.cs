﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceShoppingCart
{
    public class Item
    {
     

        public  string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Item(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }


    }
}
