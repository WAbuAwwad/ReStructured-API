using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shopping_Cart_API.Models;
using Shopping_Cart_API.Controllers;
using Moq;
using System.Net.Http;
using System.Web.Http.SelfHost;
using System.Web.Http.Hosting;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.AspNetCore.Http;
using System.Net;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.HPack;

namespace Shopping_Cart_API__Test
{
   public class ShoppingCartTest
    {

        [Fact]
        public void GetReturnsCorretctStatusCode()
        {
            //Fixture Setup 
            var shoppingCart = new Mock<IShoppingCart>();
            var sut = new ShoppingCartController(shoppingCart.Object)
            {
               Request = new HttpRequestMessage()
             };
            sut.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            //Exercise system
            var actual = sut.Get();
        
            //Verify Outcome
            Assert.True(actual.IsSuccessStatusCode);
            //Teardown
        }
    }
}
