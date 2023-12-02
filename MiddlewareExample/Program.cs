using MiddlewareExanple.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


//Örnek 1
//App ve Use Methodu


//app.Use(async (context, next) =>
//{
//    Console.WriteLine("Start Use Middleware");
//    await next.Invoke();// Kendisinden sonra gelen ilk middleware'i (Bu örnekte bir alttaki metot Run olur) çaðýrýr çalýþtýrýr tammalar
//                  // sonra kendini tamamlar
//    Console.WriteLine("Start Use Middleware");
//});


//app.Run(async context => {
//    Console.WriteLine("Run Middleware");
//});


//örnek2
// Use Method


//app.Use(async (context, next) =>
//{
//    Console.WriteLine("Start Use Middleware1");
//    await next.Invoke();
//    Console.WriteLine("Stop Use Middleware1");
//});

//app.Use(async (context, next) =>
//{
//    Console.WriteLine("Start Use Middleware2");
//    await next.Invoke();
//    Console.WriteLine("Stop Use Middleware2");
//});

//app.Use(async (context, next) =>
//{
//    Console.WriteLine("Start Use Middleware3");
//    await next.Invoke();
//    Console.WriteLine("Stop Use Middleware  3");
//});



// Map Merhod  // Request Pathe göre filtreleme

//app.Map("/weatherforecast", builder =>
//{
//    builder.Run(async c => await c.Response.WriteAsync("Map Middleware tetiklendi"));
//});

//app.Map("/home", builder =>
//{
//    builder.Use(async (context, task) =>
//    {
//        Console.WriteLine("Start middleware Map");
//        await task.Invoke();
//        Console.WriteLine("Stop middleware Map");
//    }); 
//});

// MapWhen Methodu  // Request özelliðine göre örn: request Post ise

//app.MapWhen(c => c.Request.Method == "GET", builder =>
//{
//    builder.Use(async (context, task) =>
//    {
//        await task.Invoke();
//    });
//});



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseHello();

app.UseAuthorization();

app.MapControllers();

app.Run();
