using MyShop.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Utilities.Slides
{
    public interface ISlideServices
    {
        Task<List<SlideVm>> GetAll();
    }
}