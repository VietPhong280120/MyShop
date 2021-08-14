using MyShop.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.System.Roles
{
    public interface IRoleServices
    {
        Task<List<RolesVm>> GetAll();
    }
}