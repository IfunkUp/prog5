﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dekerf_steve_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class project : DbContext
    {
        public project()
            : base("name=project")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<evenement> evenements { get; set; }
        public virtual DbSet<gemeente> gemeentes { get; set; }
        public virtual DbSet<persoon> persoons { get; set; }
        public virtual DbSet<Vraag> Vraags { get; set; }
    }
}
