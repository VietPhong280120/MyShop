using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.EF
{
   public class MyShopDbContextFactory : IDesignTimeDbContextFactory<MyShopDBcontext>
    {
        public MyShopDBcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();
            var conn = configuration.GetConnectionString("MyShopDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<MyShopDBcontext>();
        optionsBuilder.UseSqlServer(conn);

        return new MyShopDBcontext(optionsBuilder.Options);
        }
    }
}
