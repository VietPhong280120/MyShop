using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyShop.Data.EF;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Utilities.Slides
{
    public class SlideServices : ISlideServices
    {
        private readonly IConfiguration _iconfig;
        private readonly MyShopDBcontext _context;

        public SlideServices(MyShopDBcontext context, IConfiguration iconfig)
        {
            _iconfig = iconfig;
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();
            return slides;
        }
    }
}