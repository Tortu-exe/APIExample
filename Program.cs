using Microsoft.EntityFrameworkCore;
using ProbarGiladassss.Data.Models;
using ProbarGiladassss.Repositories;
using ProbarGiladassss.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<TestingContext>(options =>
    options.UseSqlite("Data Source=testing.db"));

builder.Services.AddScoped<IEspecialidadRepository, EspecialidadRepository>();
builder.Services.AddScoped<IMedicoRepository, MedicoRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200") // Angular
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseCors("AllowAngular");

app.MapControllers();

app.Run();
