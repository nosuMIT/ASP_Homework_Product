using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository productRepository;

        public ProductController() 
        {
            productRepository = new ProductRepository();
        }

        public string Index(int id)
        {
            var product = productRepository.TryGetById(id);

            if (product == null)
            {
                return $"Нет продукта с  id: {id}";
            }
            return $"{product}\n{product.Description}";


        }
    }
}
