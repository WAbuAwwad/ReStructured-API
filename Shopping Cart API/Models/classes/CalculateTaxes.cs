using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Cart_API.Models
{
    public class CalculateTaxes:ICalculateTaxes
    {
       
        public double calculateTaxes(cart MyShoppingCart)
        {
            double taxes = 0;
            foreach (var item in MyShoppingCart.Items)
            {
                taxes += item.Item.Price * item.Item.Taxe * item.Quantity;
            }
            return taxes;
        }
    }
}
