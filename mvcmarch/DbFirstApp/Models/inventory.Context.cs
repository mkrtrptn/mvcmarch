﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirstApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Inventory : DbContext
    {
        public Inventory()
            : base("name=Inventory")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<product> products { get; set; }
    
        public virtual int addp(string proddesc, Nullable<decimal> prodprice, Nullable<int> cateid)
        {
            var proddescParameter = proddesc != null ?
                new ObjectParameter("proddesc", proddesc) :
                new ObjectParameter("proddesc", typeof(string));
    
            var prodpriceParameter = prodprice.HasValue ?
                new ObjectParameter("prodprice", prodprice) :
                new ObjectParameter("prodprice", typeof(decimal));
    
            var cateidParameter = cateid.HasValue ?
                new ObjectParameter("cateid", cateid) :
                new ObjectParameter("cateid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addp", proddescParameter, prodpriceParameter, cateidParameter);
        }
    }
}
