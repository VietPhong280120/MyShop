﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Entities
{
   public class AppRole : IdentityRole<Guid>
    {
        public String Description { get; set; }
    }
}