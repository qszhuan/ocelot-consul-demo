using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace product_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]{"Laptop", "Keyboard"};
        }
    }
}