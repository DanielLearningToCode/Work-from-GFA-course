using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Basic_web.Models
{
    public class ShopItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOfStock { get; private set; }
        public ShopItem(string name, string description, int price, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityOfStock = quantity;
        }
        public ShopItem()
        {
        }
    }
}