using Shop.Data;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.mocks;
using Shop.Data.Repository;
using Shop.Data.Models;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Добавляем файл конфигурации (если используете DBSetings.json, регистрируйте его)
builder.Configuration.AddJsonFile("DBSetings.json", optional: true, reloadOnChange: true);

// Регистрация сервисов
builder.Services.AddTransient<IAllCars, CarRepository>();
builder.Services.AddTransient<ICarsCategory, CategoryRepository>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => ShopCart.GetCart(sp));

// Замена add.mvc
builder.Services.AddControllersWithViews();

builder.Services.AddMemoryCache();
builder.Services.AddSession();

// Настройка контекста базы данных
builder.Services.AddDbContext<AppDBContent>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Средства для разработки и обработка ошибок
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}
app.UseStatusCodePages();

// Поддержка статических файлов
app.UseStaticFiles();

// Настройка маршрутов (заменяет UseMvcWithDefaultRoute())
app.UseRouting();

app.UseSession();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}/{id?}"); // Определяем маршрут по умолчанию

	endpoints.MapControllerRoute( // Маршрут для фильтрации
		name: "categoryFilter",
		pattern: "Cars/List/{category}",
		defaults: new { Controller = "Cars", Action = "List" });

});

using (var scope = app.Services.CreateScope())
{
	AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
	DBOjects.Initial(content);
}

// Запуск приложения
app.Run();