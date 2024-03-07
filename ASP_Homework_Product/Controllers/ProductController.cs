using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {
            CatalogProducts catalog = new CatalogProducts();
            Product products = catalog.GetProduct(id);
            return products.ToString();
        }
    }
}
