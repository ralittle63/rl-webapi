using Microsoft.AspNetCore.Mvc;
using cswebapi1.Models;

namespace cswebapi1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get() => "Hello from your new controller!";

    [HttpPost]
    public IActionResult Post([FromBody] HelloRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (string.IsNullOrWhiteSpace(request.Name))
            return BadRequest("Name is required.");

        return Ok(new { Message = $"Hello, {request.Name}!" });
    }
}