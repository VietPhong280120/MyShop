using MyShop.ViewModels.Catalog.Categories;
using MyShop.ViewModels.Catalog.ProducImages;
using MyShop.ViewModels.Catalog.Products;
using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }
        public ProductVm Product { get; set; }
        public List<ProductVm> RelatedProducts { get; set; }
        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}