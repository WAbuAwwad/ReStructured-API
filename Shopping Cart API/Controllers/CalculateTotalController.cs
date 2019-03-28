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
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace Shopping_Cart_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateTotalController :ApiController
    {

        public ICalculateTotal CalculateTotal { get; set; }
        public CalculateTotalController(ICalculateTotal calculateTotal)
        {
            CalculateTotal = calculateTotal;
        }
        
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, CalculateTotal.calculateTotal(data.MyShoppingCart));
        }
    }
}