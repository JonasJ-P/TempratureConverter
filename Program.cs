using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy("allowAll", policy =>
    {
        policy.AllowAnyOrigin()  // Allow all origins
              .AllowAnyHeader()  // Allow any header
              .AllowAnyMethod(); // Allow any HTTP method
    });
});

var app = builder.Build();

app.UseCors("allowAll");
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.MapPost("/converter", ([FromForm] int number, [FromForm] string fromDegree, [FromForm] string toDegree)=>{
    double result = ConverterFunc.ConvertNumber(number, fromDegree, toDegree);
    return Results.Ok(result);
}).DisableAntiforgery();

app.Run();  