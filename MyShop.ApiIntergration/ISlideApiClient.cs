using MyShop.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ApiIntergration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}