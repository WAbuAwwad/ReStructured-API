using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Cart_API.Models
{
  public  interface IShoppingCart
    {
        void AddItem(cart MyShoppingCart,cartItem item);
        List<cartItem> GetItems(cart MyShoppingCart);
        void AddDiscount(cart MyShoppingCart ,discount discount);
       
    }
}
