using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XMLHttpRequest.Web.Models;

namespace XMLHttpRequest.Web.API
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            var products = new List<Product>();

            var product = new Product() { Name = "Item1", Price = 100 };
            products.Add(product);

            product = new Product() { Name = "Item2", Price = 900 };
            products.Add(product);

            product = new Product() { Name = "Item3", Price = 400 };
            products.Add(product);

            return products;
        }
    }
}
