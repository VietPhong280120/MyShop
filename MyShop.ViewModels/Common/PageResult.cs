using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ViewModels.Common
{
    public class PageResult<ProductViewModel>
    {
        public List<ProductViewModel> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
