using Microsoft.Extensions.Options;

namespace UseCase14.Middlewares
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var locOptions = context.RequestServices.GetService<IOptions<RequestLocalizationOptions>>();

            if (locOptions is null)
            {
                await _next.Invoke(context);
                return;
            }

            var supportedCultures = locOptions.Value.SupportedCultures?.Select(c => c.Name).ToList();

            if (supportedCultures is null)
            {
                await _next.Invoke(context);
                return;
            }

            var culture = context.GetRouteValue("culture")?.ToString();

            if (!string.IsNullOrWhiteSpace(culture) && !supportedCultures.Contains(culture))
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await context.Response.WriteAsync($"Culture '{culture}' not supported.");
                return;
            }

            await _next.Invoke(context);
        }
    }
}
