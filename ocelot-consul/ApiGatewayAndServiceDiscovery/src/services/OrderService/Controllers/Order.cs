using System.Collections.Generic;

namespace OrderService.Controllers
{
    public class Order
    {
        public string OrerNo { get; set; }
        public decimal Total { get; set; }

        public IEnumerable<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}