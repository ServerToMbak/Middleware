namespace Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> logger;

        public ExceptionHandlerMiddleware(RequestDelegate Next, ILogger<ExceptionHandlerMiddleware> Logger)
        {
            _next = Next;
            logger = Logger;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            try 
            {
                await _next.Invoke(httpContext);
            }
            catch (Exception ex) 
            {
                logger.LogError(ex.Message);
            }  
        }

    }
}
