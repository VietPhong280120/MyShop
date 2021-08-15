using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyShop.Data.EF;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.System.Language
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _iconfig;
        private readonly MyShopDBcontext _context;

        public LanguageService(MyShopDBcontext context, IConfiguration iconfig)
        {
            _iconfig = iconfig;
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }
    }
}