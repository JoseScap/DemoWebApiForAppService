using Microsoft.AspNetCore.Mvc;

namespace DemoWebApiForAppService;

[ApiController]
[Route("api/[controller]")]
public class DemoController(IConfiguration configuration)
{
    [HttpGet("[action]")]
    public string HelloWorld()
    {
        return nameof(HelloWorld);
    }

    [HttpGet("[action]")]
    public string SimpleValue()
    {
        var value = configuration.GetSection("Messages");
        
        return value["Value"] ?? "There is no value for [Messages:Value]";
    }
    
    [HttpGet("[action]")]
    public string DeeperValue()
    {
        var value = configuration.GetSection("Messages:Deep");
        
        return value["Value"] ?? "There is no value for [Messages:Deep:Value]";
    }

    [HttpGet("[action]")]
    public string ConnectionString()
    {
        var value = configuration.GetConnectionString("CONN_STRING");

        return value ?? "There is no value for connection string [CONN_STRING]";
    }
}