using Kolokwium_APBD_s30958.Service;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_APBD_s30958.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController : Controller
{
    private readonly ICustomersService _customersService;

    public ClientsController(ICustomersService customersService)
    {
        _customersService = customersService;
    }

    [HttpGet("{id}/purchases")]
    public async Task<IActionResult> GetCustomerOrder(int id)
    {
        var customer = await _customersService.GetCustomerOrder(id);
        return Ok(customer);
    }
}