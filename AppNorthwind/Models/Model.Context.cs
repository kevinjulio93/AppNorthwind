﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppNorthwind.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NORTHWNDEntities : DbContext
    {
        public NORTHWNDEntities()
            : base("name=NORTHWNDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Order_Details> Order_Details { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Territories> Territories { get; set; }
    }
}
