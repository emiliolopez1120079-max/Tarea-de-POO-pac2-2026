using Microsoft.EntityFrameworkCore;
using Sale.API.DataBase;
using Scalar.AspNetCore; 

var builder = WebApplication.CreateBuilder(args);

//add database service
builder.Services.AddDbContext<SalesDbContext>(options => 
 options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddOpenApi();
 
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())// solo se genera cuando esta en entorno de desarrollo
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();