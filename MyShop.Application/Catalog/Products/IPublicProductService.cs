using MyShop.ViewModels.Catalog.Products;
using MyShop.ViewModels.Catalog.Products.Public;
using MyShop.ViewModels.Common;
using System.Threading.Tasks;

namespace MyShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequests request);
    }
}
