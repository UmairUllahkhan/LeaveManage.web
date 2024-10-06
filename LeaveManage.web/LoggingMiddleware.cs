using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Serilog;
using System.Threading.Tasks;

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var routeData = context.GetRouteData();
        var controllerName = routeData?.Values["controller"]?.ToString();
        var actionName = routeData?.Values["action"]?.ToString();

        if (!string.IsNullOrEmpty(controllerName))
        {
            // Dynamically configure the log file for the controller
            var controllerLogger = new LoggerConfiguration()
                .WriteTo.File($"Logs/{controllerName}.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            // Log the controller and action name in the respective file
            controllerLogger.Information("Controller: {Controller}, Action: {Action}", controllerName, actionName);
        }

        // Call the next middleware in the pipeline
        await _next(context);
    }
}
