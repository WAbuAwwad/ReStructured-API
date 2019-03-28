using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping_Cart_API.Models;
using FromBodyAttribute = System.Web.Http.FromBodyAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;


namespace Shopping_Cart_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController :ApiController
    {
      
        public IShoppingCart ShoppingCart { get; set; }
        public ShoppingCartController(IShoppingCart shoppingCart)
        {
            ShoppingCart = shoppingCart;
        }

       
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(ShoppingCart.GetItems(data.MyShoppingCart));
        }

        [HttpPost]
        public HttpResponseMessage AddItem([FromBody] item item)
        {

            cartItem CartItem = new cartItem(item, 1, false, 0.0, 1, 1);
            ShoppingCart.AddItem(data.MyShoppingCart , CartItem);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}