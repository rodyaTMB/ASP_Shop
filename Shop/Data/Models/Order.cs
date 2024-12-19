using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
	public class Order
	{
		[BindNever]
		public int id { get; set; }

		[Display(Name = "Введите имя")]
		[StringLength(25)]
		[Required(ErrorMessage = "Длина имени не менее 5 символов")]
		public string name { get; set; }

		[Display(Name = "Введите фамилию")]
		[StringLength(25)]
		[Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
		public string surName { get; set; }

		[Display(Name = "Адрес")]
		[StringLength(50)]
		[Required(ErrorMessage = "Длина адресса не менее 15 символов")]
		public string adress { get; set; }

		[Display(Name = "Номер телефона")]
		[DataType(DataType.PhoneNumber)]
		[StringLength(20)]
		[Required(ErrorMessage = "Длина номера не менее 10 символов")]
		public string phone { get; set; }

		[Display(Name = "Email")]
		[DataType(DataType.EmailAddress)]
		[StringLength(25)]
		[Required(ErrorMessage = "Длина email не менее 10 символов")]
		public string email { get; set; }

		[BindNever]
		[ScaffoldColumn(false)]
		public DateTime orderTime{ get; set; }

		public List<OrderDetail> orderDetails { get; set; }
	}
}
