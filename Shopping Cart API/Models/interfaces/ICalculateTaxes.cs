using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Cart_API.Models
{
  public  interface ICalculateTaxes
    {
        double calculateTaxes(cart MyShoppingCart);
    }
}
