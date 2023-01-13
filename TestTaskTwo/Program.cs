using DataBaseContext.Interfaces;
using DataBaseContext.Mssq;
using DataBaseContext.Postgres;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var _connectionStrign =
    builder.Configuration.GetSection("DataBase.Postgres").Value;


// builder.Services.AddDbContext<IDataBaseContext, Mssql>(option => option.UseSqlServer(_connectionConfig));
builder.Services.AddDbContext<IDataBaseContext, Postgres>(option => option.UseNpgsql(_connectionStrign));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PizzaList}/{action=Index}");

app.UseStaticFiles();

app.Run();
