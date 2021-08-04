using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Utilities.Exceptions
{
    public class MyShopException : Exception
    {
        public MyShopException()
        {
        }
        public MyShopException(string message)
            : base(message)
        {
        }

        public MyShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
