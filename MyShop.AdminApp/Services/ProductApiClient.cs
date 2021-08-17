using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MyShop.ViewModels.Catalog.Products;
using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyShop.AdminApp.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        public ProductApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<PageResult<ProductVm>> GetPagings(GetManageProductPagingRequests request)
        {
            var data = await GetAsync<PageResult<ProductVm>>($"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}" +
                $"&languageId={request.LanguageId}");
            return data;
        }
    }
}