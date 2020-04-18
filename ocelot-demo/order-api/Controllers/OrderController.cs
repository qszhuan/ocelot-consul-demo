using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace order_api.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        [Route("api/orders")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]
            {
                "Order 1",
                "Order 2"
            };
        }
    }
}