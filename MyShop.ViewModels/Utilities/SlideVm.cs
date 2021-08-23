using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ViewModels.Utilities
{
    public class SlideVm
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public string Description { set; get; }
        public string Url { set; get; }
        public int SortOrder { set; get; }
        public string Image { get; set; }
    }
}