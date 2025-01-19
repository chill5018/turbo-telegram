using AidnNews.Application.Services;
using AidnNews.Application.UseCases;
using AidnNews.Services;
using NSwag.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<INewsCalculatorService, NewsCalculatorService>();
builder.Services.AddScoped<CalculateNewsUseCase>();


// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(config =>
{
    config.DocumentName = "AidnNews";
    config.Title = "AidnNewsAPI v1";
    config.Version = "v1";
});


var app = builder.Build();
app.UseRouting();
app.MapControllers();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi(config =>
    {
        config.DocumentTitle = "AidnNewsAPI";
        config.Path = "/swagger";
        config.DocumentPath = "/swagger/{documentName}/swagger.json";
        config.DocExpansion = "list";
    });
}


app.Run();
