using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PartialsNExpandoApi.Products.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PartialsNExpandoApi.Products
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var products = GetProducts();
            return new ObjectResult(products);
        }

        [HttpGet]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = GetProducts().Where(x => x.Id == id);
            return new ObjectResult(product);
        }

        private static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "UGA Tshirt",
                    Price = 99.95M,
                    Sizes = new List<ShirtSize>()
                    {
                        new ShirtSize() {Id = 1, Name = "Adult Medium", DisplayName = "AM"},
                        new ShirtSize() {Id = 2, Name = "Adult Large", DisplayName = "AL"}
                    }
                },
                new Product()
                {
                    Id = 2,
                    Name = "UA Tshirt",
                    Price = 89.95M,
                    Sizes = new List<ShirtSize>()
                    {
                        new ShirtSize() {Id = 1, Name = "Adult Medium", DisplayName = "AM"},
                        new ShirtSize() {Id = 2, Name = "Adult Large", DisplayName = "AL"},
                        new ShirtSize() {Id = 3, Name = "Adult X-Large", DisplayName = "AXL"}
                    }
                },

            };
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
