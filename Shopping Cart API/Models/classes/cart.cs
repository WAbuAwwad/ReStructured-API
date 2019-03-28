using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Cart_API.Models
{
    public class cart
    {
        private int id;
        private bool isEmpty;
        private List<cartItem> items;
        private List<discount> discounts;
        private string currency;
        private bool isPaid;
        public bool IsEmpty { get { return isEmpty; } }
        public List<cartItem> Items { get { return items; } }
        public List<discount> Discounts { get { return discounts; } }
        public string Currency { get { return currency; } }

        public cart(string currency)
        {
            this.isEmpty = true;
            this.items = new List<cartItem>();
            this.currency = currency;
            this.discounts = new List<discount>();
            this.isPaid = false;
        }
    }
}
