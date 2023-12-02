using MiddlewareExanple.Middlewares;

namespace MiddlewareExanple.Extensions
{
    public static class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {

            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
