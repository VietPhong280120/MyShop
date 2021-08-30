using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "MyShopDatabase";
        public const string CartSession = "CartSession";

        public class Appsetting
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeatureProducts = 4;
            public const int NumberOfLatestProducts = 6;
        }

        public class ProductConstants
        {
            public const string NA = "N/A";
        }
    }
}