using Shop.Data.Models;

namespace Shop.ViewModels
{
	public class CarsListViewModels
	{
		public IEnumerable<Car> allCars { get; set; }
		public string currCategory { get; set; }
	}
}
