using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>
            {
                new Product()
                {
                    Name = "Dell XPS15",
                    Description = "laptop",
                    Price = 3299
                },
                new Product()
                {
                    Name = "Logitech wireless Mouse",
                    Description = "mouse, anywhere II",
                    Price = 50
                },
                new Product()
                {
                Name = "CHERRY Red Axis Keyboard",
                Description = "classic",
                Price = 200
            }
            };
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        
    }
}