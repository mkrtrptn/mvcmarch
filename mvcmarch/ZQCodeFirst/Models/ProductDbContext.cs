﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ZQCodeFirst.Models
{


    public class ProductDbContext : DbContext
    {
        public DbSet<product> products { get; set; }
    }
}