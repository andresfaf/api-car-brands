using CarBrands.Application.Interfaces;
using CarBrands.Infrastructure.Data;
using CarBrands.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Se configura el contexto de la BD relacionado con la cadena de conexion
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//Se agrega el servicio del repository para poder usarlo en la inyección de dependencias
builder.Services.AddScoped<ICarBrandsRepository, CarBrandsRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
