﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Overwatch.Shared
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
     
    
    public partial class OverwatchEntities : DbContext
    {
    	public OverwatchEntities(string connectionString)
            : base(connectionString)
        {
    		}
    
        public OverwatchEntities()
            : base("name=OverwatchEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyAlert> PropertyAlerts { get; set; }
        public virtual DbSet<PropertyStatus> PropertyStatus1 { get; set; }
        public virtual DbSet<PropertyAlertStatu> PropertyAlertStatus { get; set; }
        public virtual DbSet<Severity> Severities { get; set; }
    }
}
