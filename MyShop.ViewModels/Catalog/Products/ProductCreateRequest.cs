using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public decimal Price { get; set; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { set; get; }

        public bool? IsFeatured { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { set; get; }

        [Required(ErrorMessage = "Details is required")]
        public string Details { set; get; }

        [Required(ErrorMessage = "SeoDescription is required")]
        public string SeoDescription { set; get; }

        [Required(ErrorMessage = "SeoTitle is required")]
        public string SeoTitle { set; get; }

        [Required(ErrorMessage = "SeoAlias is required")]
        public string SeoAlias { get; set; }

        public string LanguageId { set; get; }
        public IFormFile ThumbnailImage { get; set; }
    }
}