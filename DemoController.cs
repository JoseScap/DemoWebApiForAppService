using Microsoft.AspNetCore.Mvc;

namespace DemoWebApiForAppService;

[ApiController]
[Route("api/[controller]")]
public class DemoController
{
    [HttpGet("HelloWorld")]
    public string HelloWorld()
    {
        return "Hello world";
    }
}