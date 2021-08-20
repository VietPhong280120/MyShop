using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequests : PagingRequestBase
    {
        public string Keyword { get; set; }

        public string LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}