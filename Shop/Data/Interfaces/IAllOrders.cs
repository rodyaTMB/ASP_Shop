using Shop.Data.Models;
using Shop.Migrations;

namespace Shop.Data.Interfaces
{
	public interface IAllOrders
	{
		public void createOrder(Order order);
	}
}
