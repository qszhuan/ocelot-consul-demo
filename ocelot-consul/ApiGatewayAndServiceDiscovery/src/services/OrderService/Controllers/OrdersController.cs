using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return new List<Order>
            {
                new Order
                {
                    OrerNo = "Order 001",
                    Total = 3010,
                    Items = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            ProductName = "Pencil",
                            Quantity = 10,
                            UnitPrice = 1,
                            Unit = "Pack"
                        },
                        new OrderItem
                        {
                            ProductName = "Laptop",
                            Quantity = 1,
                            UnitPrice = 3000,
                            Unit = "Piece"
                        }
                    }
                }
            };
        }
    }
}