using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Cart_API.Models
{
    public class ShoppingCart : IShoppingCart
    {

        public void AddDiscount(cart MyShoppingCart ,discount discount)
        {
            throw new NotImplementedException();
        }

        public void AddItem(cart MyShoppingCart , cartItem item)
        {

             MyShoppingCart.Items.Add(item);
        }

        public List<cartItem> GetItems(cart MyShoppingCart)
        {
            
          return MyShoppingCart.Items;
         
        }
    }
}
