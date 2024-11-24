﻿using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System.Diagnostics;

namespace Shop.Controllers
{
	public class CarsController : Controller
	{
		private readonly IAllCars _allCars;
		private readonly ICarsCategory _allCategories;

		public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
		{
			_allCars = iAllCars;
			_allCategories = iCarsCategory;
		}

		[Route("Cars/List")]
		[Route("Cars/List/{category}")]
		public ViewResult List(string category)
		{
			string _category = category;
			IEnumerable<Car> cars = null;
			string currCategory = "";
			if (string.IsNullOrEmpty(category))
			{
				cars = _allCars.Cars.OrderBy(i => i.Id);
			}
			else
			{
				if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
				{
					cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.Id);
					currCategory = "Электрические автомобили";
				}
				else
				{
					if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
					{
						cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Класические автомобили")).OrderBy(i => i.Id);
						currCategory = "Автомобили с двигателем внутреннего сгорания";
					}
				}
			}

			var carObj = new CarsListViewModels
			{
				allCars = cars,
				currCategory = currCategory
			};

			ViewBag.Title = "Страница с автомобилями";

			return View(carObj);
		}
	}
}
