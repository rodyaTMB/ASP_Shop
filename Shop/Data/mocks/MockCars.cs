using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
	public class MockCars : IAllCars
	{
		private readonly ICarsCategory _categoryCars = new MockCategory();

		public IEnumerable<Car> Cars
		{
			get
			{
				return new List<Car>
				{
					new Car {
						name = "Tesla",
						shortDescription = "Электрический премиум-седан",
						longDescription = "Tesla — это высокотехнологичный электромобиль, известный своим минималистичным дизайном и функцией автопилота. Идеален для поездок на большие расстояния.",
						img = "/img/Tesla.jpg",
						price = 45000,
						isFavourite = true,
						available = true,
						Category = _categoryCars.AllCategories.First()
					},

					new Car {
						name = "Tesla Model 3",
						shortDescription = "Доступный электромобиль с большим запасом хода",
						longDescription = "Model 3 — популярный электрокар с отличной динамикой и возможностью автоматического вождения, подходящий для повседневного использования.",
						img = "/img/Tesla Model 3.jpg",
						price = 40000,
						isFavourite = true,
						available = true,
						Category = _categoryCars.AllCategories.First()
					},

					new Car {
						name = "Nissan Leaf",
						shortDescription = "Компактный и экологичный электромобиль",
						longDescription = "Nissan Leaf — один из первых массовых электромобилей, созданный для удобных и экономичных поездок в городе.",
						img = "/img/Nissan Leaf.jpeg",
						price = 32000,
						isFavourite = false,
						available = true,
						Category = _categoryCars.AllCategories.First()
					},

					new Car {
						name = "Chevrolet Bolt EV",
						shortDescription = "Практичный электромобиль с хорошим запасом хода",
						longDescription = "Bolt EV предлагает компактный размер и впечатляющий запас хода, идеально подходит для городских поездок и ежедневного использования.",
						img = "/img/Chevrolet Bolt EV.jpeg",
						price = 37000,
						isFavourite = false,
						available = true,
						Category = _categoryCars.AllCategories.First()
					},

					new Car {
						name = "Audi e-tron",
						shortDescription = "Элегантный и мощный электрический внедорожник",
						longDescription = "Audi e-tron — роскошный электрический внедорожник, сочетающий стиль, мощность и экологичность.",
						img = "/img/Audi e-tron.jpg",
						price = 65500,
						isFavourite = true,
						available = true,
						Category = _categoryCars.AllCategories.First()
					},

					new Car {
						name = "Ford Mustang Mach-E",
						shortDescription = "Электрический кроссовер с дерзким характером",
						longDescription = "Mustang Mach-E сочетает традиционный спортивный стиль Mustang с эффективностью и дальностью электромобиля.",
						img = "/img/Ford Mustang Mach-E.jpg",
						price = 55000,
						isFavourite = true,
						available = true,
						Category = _categoryCars.AllCategories.First()
					},

					new Car {
						name = "BMW 3 Series",
						shortDescription = "Спортивный и роскошный седан",
						longDescription = "BMW 3 Series предлагает динамичное вождение и комфорт в сочетании с классическим стилем и бензиновым двигателем.",
						img = "/img/BMW 3 Series.jpg",
						price = 41000,
						isFavourite = true,
						available = true,
						Category = _categoryCars.AllCategories.Last()
					},

					new Car {
						name = "Toyota Camry",
						shortDescription = "Надежный и экономичный седан",
						longDescription = "Toyota Camry известен своей надежностью и комфортом, это идеальный автомобиль для ежедневных поездок и длительных путешествий.",
						img = "/img/Toyota Camry.jpg",
						price = 30000,
						isFavourite = true,
						available = true,
						Category = _categoryCars.AllCategories.Last()
					},

					new Car {
						name = "Honda Accord",
						shortDescription = "Комфортный и экономичный седан",
						longDescription = "Honda Accord предлагает комфортный салон, экономичность и надежность, что делает его популярным выбором среди седанов.",
						img = "/img/Honda Accord.webp",
						price = 29000,
						isFavourite = false,
						available = true,
						Category = _categoryCars.AllCategories.Last()
					},

					new Car {
						name = "Ford F-150",
						shortDescription = "Мощный и практичный пикап",
						longDescription = "Ford F-150 — надежный пикап, известный своей мощностью, выносливостью и способностью перевозить большие грузы.",
						img = "/img/Ford F-150.jpg",
						price = 35000,
						isFavourite = false,
						available = true,
						Category = _categoryCars.AllCategories.Last()
					},


				};
			}
		}
		public IEnumerable<Car> getFavCars { get; set; }

		public Car getObjectCar(int carId)
		{
			throw new NotImplementedException();
		}
	}
}
