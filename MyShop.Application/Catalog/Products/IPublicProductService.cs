using MyShop.ViewModels.Catalog.Products;
using MyShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequests request);
    }
}