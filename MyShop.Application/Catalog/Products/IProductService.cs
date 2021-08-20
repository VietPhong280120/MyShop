using Microsoft.AspNetCore.Http;
using MyShop.ViewModels.Catalog.ProducImages;
using MyShop.ViewModels.Catalog.Products;
using MyShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyShop.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<ProductVm> GetById(int productId, string languageId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addQuantity);

        Task AddViewCount(int productId);

        Task<PageResult<ProductVm>> GetAllPaging(GetManageProductPagingRequests request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<List<ProductImageViewModel>> GetListImage(int productId);

        Task<PageResult<ProductVm>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequests request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
    }
}