﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CustomerModel : DbContext
    {
        public CustomerModel()
            : base("name=CustomerModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_CUSTOMERS> TBL_CUSTOMERS { get; set; }
        public virtual DbSet<TBL_DIRECTIONS> TBL_DIRECTIONS { get; set; }
        public virtual DbSet<TBL_MESSAGES> TBL_MESSAGES { get; set; }
        public virtual DbSet<TBL_CONTACTMETHODS> TBL_CONTACTMETHODS { get; set; }
    }
}
