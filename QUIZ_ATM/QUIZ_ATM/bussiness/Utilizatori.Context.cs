﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUIZ_ATM.bussiness
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UtilizatoriEntities : DbContext
    {
        public UtilizatoriEntities()
            : base("name=UtilizatoriEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Statistica> Statisticas { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Utilizatori> Utilizatoris { get; set; }
    }
}
