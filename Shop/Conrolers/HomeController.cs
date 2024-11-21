using Shop.Data.Interfaces;
using Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Conrolers
{
	public class HomeController : Controller
	{
		private IAllCars _carRep;

		public HomeController(IAllCars carRep)
		{
			_carRep = carRep;
		}
		public ViewResult Index()
		{
			var homeCars = new HomeViewModel
			{
				favCars = _carRep.getFavCars
			};
			return View(homeCars);
		}
	}

}
