using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICartsRepository _cartRepository;
        private readonly IConstants _constants;
        private readonly IOrderRepository _orderRepository;
        public OrderController(IProductRepository productRepository, ICartsRepository cartRepository, IConstants constants, IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _cartRepository = cartRepository;
            _constants = constants;
            _orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Buy()
        {
            Cart cart = _cartRepository.TryGetByUId(_constants.GetUserId);
            _orderRepository.Add(cart);
            _cartRepository.Clear(_constants.GetUserId);
            return View();
        }
    }
}
