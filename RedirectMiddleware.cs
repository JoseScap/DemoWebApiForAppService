namespace DemoWebApiForAppService;

public class RedirectMiddleware(RequestDelegate next, ILogger<RedirectMiddleware> logger, string from, string to)
{
    public async Task InvokeAsync(HttpContext context)
    {
        logger.LogInformation(context.Request.Path);
        
        if (context.Request.Path == from)
        {
            context.Response.Redirect(to);
            return;
        }
        await next(context);
    }
}

public static class RedirectMiddlewareExtensions
{
    public static IApplicationBuilder UseRedirectTo(this IApplicationBuilder builder, string from, string to)
    {
        return builder.UseMiddleware<RedirectMiddleware>(from, to);
    }
}
