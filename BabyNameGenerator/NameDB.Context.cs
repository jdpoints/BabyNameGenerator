﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BabyNameGenerator
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NameGeneratorContext : DbContext
    {
        public NameGeneratorContext()
            : base("name=NameGeneratorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<first_name> first_name { get; set; }
        public virtual DbSet<full_name> full_name { get; set; }
        public virtual DbSet<middle_name> middle_name { get; set; }
    }
}