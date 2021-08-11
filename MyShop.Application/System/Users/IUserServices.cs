using MyShop.ViewModels.Common;
using MyShop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.System.Users
{
    public interface IUserServices
    {
        Task<string> Authenticate(LoginRequest request);

        Task<bool> Register(RegisterRequest register);

        Task<PageResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }
}