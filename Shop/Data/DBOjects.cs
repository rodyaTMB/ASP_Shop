using Shop.Data.Models;

namespace Shop.Data
{
	public class DBOjects
	{
		public static void Initial(AppDBContent content)
		{

			if (!content.Category.Any())
			{
				content.Category.AddRange(Categories.Select(c => c.Value));
			}

			if (!content.Car.Any())
			{
				content.AddRange(
					new Car
					{
						name = "Tesla",
						shortDescription = "Электрический премиум-седан",
						longDescription = "Tesla — это высокотехнологичный электромобиль, известный своим минималистичным дизайном и функцией автопилота. Идеален для поездок на большие расстояния.",
						img = "/img/Tesla.jpg",
						price = 45000,
						isFavourite = true,
						available = true,
						Category = Categories["Электромобили"]
					},

					new Car
					{
						name = "Tesla Model 3",
						shortDescription = "Доступный электромобиль с большим запасом хода",
						longDescription = "Model 3 — популярный электрокар с отличной динамикой и возможностью автоматического вождения, подходящий для повседневного использования.",
						img = "/img/Tesla Model 3.jpg",
						price = 40000,
						isFavourite = true,
						available = true,
						Category = Categories["Электромобили"]
					},

					new Car
					{
						name = "Nissan Leaf",
						shortDescription = "Компактный и экологичный электромобиль",
						longDescription = "Nissan Leaf — один из первых массовых электромобилей, созданный для удобных и экономичных поездок в городе.",
						img = "/img/Nissan Leaf.jpeg",
						price = 32000,
						isFavourite = false,
						available = true,
						Category = Categories["Электромобили"]
					},

					new Car
					{
						name = "Chevrolet Bolt EV",
						shortDescription = "Практичный электромобиль с хорошим запасом хода",
						longDescription = "Bolt EV предлагает компактный размер и впечатляющий запас хода, идеально подходит для городских поездок и ежедневного использования.",
						img = "/img/Chevrolet Bolt EV.jpeg",
						price = 37000,
						isFavourite = false,
						available = true,
						Category = Categories["Электромобили"]
					},

					new Car
					{
						name = "Audi e-tron",
						shortDescription = "Элегантный и мощный электрический внедорожник",
						longDescription = "Audi e-tron — роскошный электрический внедорожник, сочетающий стиль, мощность и экологичность.",
						img = "/img/Audi e-tron.jpg",
						price = 65500,
						isFavourite = true,
						available = true,
						Category = Categories["Электромобили"]
					},

					new Car
					{
						name = "Ford Mustang Mach-E",
						shortDescription = "Электрический кроссовер с дерзким характером",
						longDescription = "Mustang Mach-E сочетает традиционный спортивный стиль Mustang с эффективностью и дальностью электромобиля.",
						img = "/img/Ford Mustang Mach-E.jpg",
						price = 55000,
						isFavourite = true,
						available = true,
						Category = Categories["Электромобили"]
					},

					new Car
					{
						name = "BMW 3 Series",
						shortDescription = "Спортивный и роскошный седан",
						longDescription = "BMW 3 Series предлагает динамичное вождение и комфорт в сочетании с классическим стилем и бензиновым двигателем.",
						img = "/img/BMW 3 Series.jpg",
						price = 41000,
						isFavourite = true,
						available = true,
						Category = Categories["Класические автомобили"]
					},

					new Car
					{
						name = "Toyota Camry",
						shortDescription = "Надежный и экономичный седан",
						longDescription = "Toyota Camry известен своей надежностью и комфортом, это идеальный автомобиль для ежедневных поездок и длительных путешествий.",
						img = "/img/Toyota Camry.jpg",
						price = 30000,
						isFavourite = true,
						available = true,
						Category = Categories["Класические автомобили"]
					},

					new Car
					{
						name = "Honda Accord",
						shortDescription = "Комфортный и экономичный седан",
						longDescription = "Honda Accord предлагает комфортный салон, экономичность и надежность, что делает его популярным выбором среди седанов.",
						img = "/img/Honda Accord.webp",
						price = 29000,
						isFavourite = false,
						available = true,
						Category = Categories["Класические автомобили"]
					},

					new Car
					{
						name = "Ford F-150",
						shortDescription = "Мощный и практичный пикап",
						longDescription = "Ford F-150 — надежный пикап, известный своей мощностью, выносливостью и способностью перевозить большие грузы.",
						img = "/img/Ford F-150.jpg",
						price = 35000,
						isFavourite = false,
						available = true,
						Category = Categories["Класические автомобили"]
					}
				);
			}

			content.SaveChanges();
		}

		public static Dictionary<string, Category> category;
		public static Dictionary<string, Category> Categories
		{
			get
			{
				if (category == null)
				{
					var list = new Category[]
					{
						new Category { categoryName = "Электромобили", description = "Современный вид транспорта"},
						new Category { categoryName = "Класические автомобили", description = "Машины с двигателем внутреннего сгорания"}
					};

					category = new Dictionary<string, Category>();
					foreach (Category el in list)
					{
						category.Add(el.categoryName, el);
					}
				}

				return category;

			}
		}
	}
}
