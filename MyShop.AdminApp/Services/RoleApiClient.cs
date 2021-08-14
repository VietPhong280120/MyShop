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
    public class RoleApiClient : IRoleApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RoleApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<List<RolesVm>>> GetAll()
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/roles");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                List<RolesVm> myDeserializedObjList = (List<RolesVm>)JsonConvert.DeserializeObject(body, typeof(List<RolesVm>));
                return new ApiSuccessResult<List<RolesVm>>(myDeserializedObjList);
            }
            return JsonConvert.DeserializeObject<ApiErrorResult<List<RolesVm>>>(body);
        }
    }
}