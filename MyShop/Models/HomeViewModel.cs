using MyShop.ViewModels.Catalog.Products;
using MyShop.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }
        public List<ProductVm> FeaturedProducts { get; set; }
    }
}