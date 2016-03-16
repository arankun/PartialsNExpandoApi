using System.Collections.Generic;

namespace PartialsNExpandoApi.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<ShirtSize> Sizes { get; set; }
    }
}