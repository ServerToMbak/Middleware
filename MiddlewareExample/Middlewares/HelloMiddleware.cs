namespace MiddlewareExanple.Middlewares;

public class HelloMiddleware 
{
    RequestDelegate Next;
    public HelloMiddleware(RequestDelegate next)
    {
           Next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        // Custom Operasyon
        Console.WriteLine("Helooo!!");
        await Next.Invoke(context);
        Console.WriteLine("Hello Completed");
    }
}
