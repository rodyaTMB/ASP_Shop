using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
	public class OrderRepository : IAllOrders
	{
		private readonly AppDBContent appDBContent;
		private readonly ShopCart shopCart;

		public OrderRepository(AppDBContent appDBContent, ShopCart shopCart)
		{
			this.appDBContent = appDBContent;
			this.shopCart = shopCart;
		}

		public void createOrder(Order order)
		{
			order.orderTime = DateTime.Now;
			appDBContent.Order.Add(order);

			var items = shopCart.listShopItems;

			foreach (var item in items)
			{
				var orderDetail = new OrderDetail()
				{
					CarID = item.car.Id,
					orderID = order.id,
					price = item.car.price
				};

				appDBContent.OrderDetail.Add(orderDetail);
			}

			appDBContent.SaveChanges(); 
		}
	}
}
