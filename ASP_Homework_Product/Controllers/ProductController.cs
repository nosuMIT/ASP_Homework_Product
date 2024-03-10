using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductStorage Product = new ProductStorage();
        public string Index(int id)
        {
            
            foreach (Product item in Product)
            {
                if (item.CompareId(id))
                {
                    return item.ToString();
                }
            }
            return $"Такого товара нет!!!";
        }
    }
}
