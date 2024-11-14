using Shop.Data.Interfaces;
using Shop.Data.mocks;

var builder = WebApplication.CreateBuilder(args);

// Регистрация сервисов
builder.Services.AddTransient<IAllCars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();
builder.Services.AddControllersWithViews(); // В новой версии используется AddControllersWithViews() вместо AddMvc()

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
		pattern: "{controller=Cars}/{action=List}/{id?}"); // Здесь определяем маршрут по умолчанию
});

// Запуск приложения
app.Run();
