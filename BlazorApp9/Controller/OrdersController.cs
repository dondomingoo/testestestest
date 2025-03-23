using Microsoft.AspNetCore.Mvc;
using BlazorApp9.Shared; // <-- Importer shared models

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetOrders()
    {
        var orders = new List<Order>
        {
            new Order { Id = 1, CustomerName = "Alice", OrderDate = DateTime.Now },
            new Order { Id = 2, CustomerName = "Bob", OrderDate = DateTime.Now.AddDays(-1) }
        };

        return Ok(orders);
    }
}
