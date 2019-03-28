using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shopping_Cart_API.Models
{
    public class CalculateTotal : ICalculateTotal
    {

   

        public double calculateTotal(cart myShoppingCart)
        {
            double total = 0;
            foreach (var item in myShoppingCart.Items)
            {

                total += item.Item.Price * item.Quantity;
            }
            return total;
        }
    }
}
