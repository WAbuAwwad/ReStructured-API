using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Cart_API.Models
{
    public class CalculatePayment:ICalculatePayment
    {


  
       CalculateTotal calTotal = new CalculateTotal();
       CalculateTaxes calTaxes = new CalculateTaxes();
       CalculateDiscount calDiscount = new CalculateDiscount();
        exchangeRate exRate = new exchangeRate();
        

        public double calculatePayment(cart MyShoppingCart)
        {
            double bills = calTotal.calculateTotal(MyShoppingCart) + calTaxes.calculateTaxes(MyShoppingCart) - calDiscount.calculateDiscount(MyShoppingCart);
            return bills * exRate.ExchangeCurrency(MyShoppingCart.Currency);

        }
    }

}
