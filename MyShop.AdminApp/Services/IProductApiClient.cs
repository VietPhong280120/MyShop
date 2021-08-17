using MyShop.ViewModels.Catalog.Products;
using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PageResult<ProductVm>> GetPagings(GetManageProductPagingRequests request);

        Task<bool> CreateProduct(ProductCreateRequest request);
    }
}