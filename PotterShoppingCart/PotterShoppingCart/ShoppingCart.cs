using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {    

        public int TotalPrice { get; set; }
        

        public void CalcFee(List<Book> order)
        {
            TotalPrice = order.Sum(x => x.SellPrice);
        }
    }
}