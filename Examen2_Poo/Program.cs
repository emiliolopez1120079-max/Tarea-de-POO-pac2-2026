using Microsoft.EntityFrameworkCore;
using Examen2_Poo.DataBase;
using Scalar.AspNetCore; 
var builder = WebApplication.CreateBuilder(args); 

//add database service
builder.Services.AddDbContext<SalesDbContext>(options => 
 options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddOpenApi();
 
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();