using System.Collections.Generic;
using System.Linq;
using Lab9.Models;
using Microsoft.AspNetCore.Mvc;
namespace Lab9.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> products;
        public ProductController()
        {
            if (products == null)
                InitializeProducts();
        }
        private void InitializeProducts()
        {
            products = new List<Product>
 {
 new Product { ProductID = 1000, ProductName = "Bath foam",
 Description = "Mega dose, XXL 1000 ml",
ImagePath = "images/b1.jpg",
UnitPrice = 7.50, CategoryID = 1 },
 new Product { ProductID = 1001,
 ProductName = "Encouraging your shower",
 Description = "Wake up mode, XL 500 ml",
ImagePath = "images/b2.jpg",
 UnitPrice = 2.79, CategoryID = 1 },
 new Product { ProductID = 1002, ProductName = "Foot care",
 Description = "Special products with ginger and white tea",
ImagePath = "images/b3.jpg",
UnitPrice = 4.90, CategoryID = 1 },
 new Product { ProductID = 1003, ProductName = "Natural care",
 Description = "Bdy grooming",
ImagePath = "images/b4.jpg",
UnitPrice = 4.90, CategoryID = 1 },
 new Product {ProductID = 1004, ProductName = "Romantic shower",
 Description = "11 different scents for a sensational "
 + "shower", ImagePath = "images/b5.jpg",
 UnitPrice = 3.99, CategoryID = 1 },
 new Product { ProductID = 1005, ProductName = "Hand care",
 Description = "Early hand creams",
ImagePath = "images/b6.jpg",
UnitPrice = 4.90, CategoryID = 1 },
 new Product {ProductID = 1100, ProductName = "Liquid eyeliner",
 Description = "Outline precise lines and perfectly "
 + "emphasize the eyes",
 ImagePath = "images/f1.jpg",
UnitPrice = 6.90, CategoryID = 2 },
 new Product { ProductID = 1101, ProductName = "Spiral",
 Description = "Maximum volume eyelashes - up to 15x times "
 + "more volume", ImagePath = "images/f2.jpg",
 UnitPrice = 9.90, CategoryID = 2 },
 new Product { ProductID = 1102, ProductName = "Face cream",
 Description = "A considerably firmer and more youthful "
 + "looking skin in just two weeks",
 ImagePath = "images/f3.jpg",
UnitPrice = 16.00, CategoryID = 2 },
 new Product { ProductID = 1103, ProductName = "Face makeup",
 Description = "Soft glow and hydration, light color "
 + "and care", ImagePath = "images/f4.jpg",
 UnitPrice = 5.90, CategoryID = 2 },
 new Product { ProductID = 1104,
 ProductName = "Eye shadow and makeup",
Description = "Diamond gloss, matte color and "
 + "hydrating sensation", ImagePath = "images/f5.jpg",
 UnitPrice = 4.90, CategoryID = 2 },
 new Product { ProductID = 1105, ProductName = "Lipsticks",
 Description = "Brilliant color without lip-drying",
 ImagePath = "images/f6.jpg",
UnitPrice = 6.90, CategoryID = 2 },
 new Product { ProductID = 1200, ProductName = "Hair dye",
 Description = "Professional effect-long-lasting color, "
 + "100% coverage of grey hair",
 ImagePath = "images/h1.jpg",
UnitPrice = 8.90, CategoryID = 3 },
 new Product { ProductID = 1201, ProductName = "New hairstyle",
 Description = "Hair styling accessories",
ImagePath = "images/h2.jpg",
UnitPrice = 2.90, CategoryID = 3 },
 new Product { ProductID = 1202, ProductName = "Hairbrush",
 Description = "Brushes for easy combing and "
 + "straightening of hair", ImagePath = "images/h3.jpg",
 UnitPrice = 5.90, CategoryID = 3 },
 new Product { ProductID = 1203,
 ProductName = "Conditioners and shampoos",
Description = "Hair conditioners and shampoos for Shine, "
 + "volume, recovery and against dandruff",
 ImagePath = "images/h4.jpg",
UnitPrice = 5.00, CategoryID = 3 },
 new Product { ProductID = 1204,
 ProductName = "Shampoo for healthy hair",
Description = "Argan oil therapy",
ImagePath = "images/h5.jpg",
UnitPrice = 4.50, CategoryID = 3 },
 new Product { ProductID = 1205, ProductName = "Luxury therapy",
 Description = "The best care for a beautiful hairstyle",
ImagePath = "images/h6.jpg",
UnitPrice = 5.50, CategoryID = 3 }
 };
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Beauty Shop";
            return View(products.OrderByDescending(x => x.CategoryID));
        }
    }
}
