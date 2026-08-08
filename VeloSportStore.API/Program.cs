using Microsoft.EntityFrameworkCore;
using VeloSportStore.API.Infrastructure.Database;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql(
        builder
        .Configuration["ConnectionStrings:Default"]
    );
});

var app = builder.Build();
app.MapGet("/endpoints", (IEnumerable<EndpointDataSource> endpoints) =>
    string.Join("\n", endpoints.SelectMany(src => src.Endpoints))
);

// Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Map controllers
app.MapControllers();

app.Run();