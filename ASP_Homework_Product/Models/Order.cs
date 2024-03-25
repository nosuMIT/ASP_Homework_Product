using System.ComponentModel.DataAnnotations;

namespace ASP_Homework_Product.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Укажите имя")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Укажите email")]
        [EmailAddress(ErrorMessage = "Укажите валидный email")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Укажите Адрес")]
		public string Address { get; set; }
        public Cart Cart { get; set; }
    }
}
