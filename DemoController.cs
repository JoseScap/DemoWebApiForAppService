using Microsoft.AspNetCore.Mvc;

namespace DemoWebApiForAppService;

[ApiController]
[Route("api/[controller]")]
public class DemoController(IConfiguration configuration, ILogger<DemoController> logger)
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
    
    [HttpGet("[action]")]
    public string Log(
        [FromQuery] string message = "Default value",
        [FromQuery] LogLevel logLevel = LogLevel.Debug
        )
    {
        switch (logLevel)
        {
            case LogLevel.Debug:
                logger.LogDebug("[Debug]: {0}", message);
                break;
            case LogLevel.Information:
                logger.LogInformation("[Information]: {0}", message);
                break;
            case LogLevel.Trace:
                logger.LogTrace("[Trace]: {0}", message);
                break;
            case LogLevel.Warning:
                logger.LogWarning("[Warning]: {0}", message);
                break;
            case LogLevel.Error:
                logger.LogError("[Error]: {0}", message);
                break;
            case LogLevel.Critical:
                logger.LogCritical("[Critical]: {0}", message);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null);
        }
        
        return "Your message was logged";
    }
}

public enum LogLevel : byte
{
    Debug,
    Information,
    Trace,
    Warning,
    Error,
    Critical
}