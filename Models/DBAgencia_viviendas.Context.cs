﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen_AgenciaViviendas.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBAgencia_viviendasEntities : DbContext
    {
        public DBAgencia_viviendasEntities()
            : base("name=DBAgencia_viviendasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGEncia> AGEncias { get; set; }
        public virtual DbSet<CLIente> CLIentes { get; set; }
        public virtual DbSet<TIPoVivienda> TIPoViviendas { get; set; }
        public virtual DbSet<VENta> VENtas { get; set; }
        public virtual DbSet<VIVienda> VIViendas { get; set; }
    }
}
