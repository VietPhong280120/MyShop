using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.System.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MyShop.AdminApp.Services
{
    public class RoleApiClient : BaseApiClient, IRoleApiClient
    {
        public RoleApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<List<RolesVm>>> GetAll()
        {
            return await GetAsync<ApiErrorResult<List<RolesVm>>>("/api/roles");
        }
    }
}