using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Cart_API.Models
{
    public class CalculateDiscount:ICalculateDiscount
    {
        CalculateTotal calTotal= new CalculateTotal();

        public double calculateDiscount(cart MyShoppingCart)
        {
            double discount = 0;
            foreach (var Discount in MyShoppingCart.Discounts)
            {
                if (Discount.Type == DiscountType.noDiscount) discount += 0.0;

                if (Discount.Type == DiscountType.perCart)
                    discount += calTotal.calculateTotal(MyShoppingCart) * Discount.Percentage;

                foreach (var item in MyShoppingCart.Items)
                {
                    if (Discount.Type == DiscountType.perItem && item.HasDiscount)
                        discount += item.Item.Price * item.Discount * item.Quantity;
                    else if (Discount.Type == DiscountType.perType && item.HasDiscount)
                        discount += item.Item.Price * item.Discount;
                }
            }
            return discount;
        }
    }
}
