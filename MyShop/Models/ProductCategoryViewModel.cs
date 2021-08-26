using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.ViewModels.Catalog.Categories;
using MyShop.ViewModels.Catalog.Products;
using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }
        public PageResult<ProductVm> Product { get; set; }
    }
}