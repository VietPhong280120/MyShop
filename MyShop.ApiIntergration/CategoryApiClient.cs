using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MyShop.ApiIntergration;
using MyShop.ViewModels.Catalog.Categories;
using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyShop.ApiIntergration
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                 IHttpContextAccessor httpContextAccessor,
                  IConfiguration configuration) :
          base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            return await GetListAsync<CategoryVm>("/api/Categories?languageId=" + languageId);
        }

        public async Task<CategoryVm> GetById(string languageId, int id)
        {
            return await GetAsync<CategoryVm>($"/api/categories/{id}/{languageId}");
        }
    }
}