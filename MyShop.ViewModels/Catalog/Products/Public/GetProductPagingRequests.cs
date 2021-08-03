using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequests : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
