﻿using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controlers
{
	public class ShopCartController : Controller
	{
		private IAllCars _carRep;
		private readonly ShopCart _shopCart;

		public ShopCartController(IAllCars carRep, ShopCart shopCart)
		{
			_carRep = carRep;
			_shopCart = shopCart;
		}

		public ViewResult Index()
		{
			var items = _shopCart.getShopItems();
			_shopCart.listShopItems = items;

			var obj = new ShopCartViewModel
			{
				shopCart = _shopCart
			};

			return View(obj);
		}

		public RedirectToActionResult addToCart(int id)
		{
			var item = _carRep.Cars.FirstOrDefault(i => i.Id == id);
			if (item != null)
			{
				_shopCart.AddToCart(item);
			}
			return RedirectToAction("index");
		}
	}
}
