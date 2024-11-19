using Shop.Data;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.mocks;
using Shop.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Добавляем файл конфигурации (если используете DBSetings.json, регистрируйте его)
builder.Configuration.AddJsonFile("DBSetings.json", optional: true, reloadOnChange: true);

// Регистрация сервисов
builder.Services.AddTransient<IAllCars, CarRepository>();
builder.Services.AddTransient<ICarsCategory, CategoryRepository>();
builder.Services.AddControllersWithViews();

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

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		name: "default",
		pattern: "{controller=Cars}/{action=List}/{id?}"); // Определяем маршрут по умолчанию
});

using (var scope = app.Services.CreateScope())
{
	AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
	DBOjects.Initial(content);
}

// Запуск приложения
app.Run();

//Тестовый комит 3