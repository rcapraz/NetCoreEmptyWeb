using Microsoft.AspNetCore.Mvc;
using NetCoreEmptyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEmptyWeb.ViewComponents
{
    public class MenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category(){Name="Kategori1"},
                new Category(){Name="Kategori2"},
                new Category(){Name="Kategori3"}
            };
            return View(categories);
        }
    }
}
