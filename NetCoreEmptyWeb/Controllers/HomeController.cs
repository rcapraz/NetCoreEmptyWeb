using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreEmptyWeb.Models;
using NetCoreEmptyWeb.ViewModels;

namespace NetCoreEmptyWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>()
            {
                new Category(){Name="Kategori1"},
                new Category(){Name="Kategori2"},
                new Category(){Name="Kategori3"}
            };
            var products = new List<Product>()
            {
                new Product(){Name="Product1"},
                new Product(){Name="Product2"},
                new Product(){Name="Product3"}
            };
            //var model = new ProductsCategoriesViewModel();
            //model.Products = products;
            //model.Categories = categories;
            ////int saat = DateTime.Now.Hour;
            ////ViewBag.Greeting = saat > 12 ? "iyi günler" : "Günaydın";
            ////ViewBag.Username = "Ahmet";
            return View();//model
        }
        public IActionResult About()
        {
            //var categories = new List<Category>()
            //{
            //    new Category(){Name="Kategori1"},
            //    new Category(){Name="Kategori2"},
            //    new Category(){Name="Kategori3"}
            //};
            //var products = new List<Product>()
            //{
            //    new Product(){Name="Product1"},
            //    new Product(){Name="Product2"},
            //    new Product(){Name="Product3"}
            //};
            //    var model = new ProductsCategoriesViewModel();
            //    model.Products = products;
            //    model.Categories = categories;
            return View();//model
            //}
        }
    }
}
