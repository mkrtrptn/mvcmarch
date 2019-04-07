using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirstApp.Models;

namespace CodeFirstApp.Models
{
    public class mycontext : DbContext 
    {
        public DbSet<dept> department { set; get; }
        public DbSet<employee> employees { set; get; }
    }
}