﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTIDAD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdaisurEntities : DbContext
    {
        public bdaisurEntities()
            : base("name=bdaisurEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<arma> arma { get; set; }
        public virtual DbSet<armaExplosiva> armaExplosiva { get; set; }
        public virtual DbSet<arsenalSoldado> arsenalSoldado { get; set; }
        public virtual DbSet<clasificacion> clasificacion { get; set; }
        public virtual DbSet<marca> marca { get; set; }
        public virtual DbSet<pais> pais { get; set; }
        public virtual DbSet<paisArma> paisArma { get; set; }
        public virtual DbSet<paisArmaExplosiva> paisArmaExplosiva { get; set; }
        public virtual DbSet<paisVehiculo> paisVehiculo { get; set; }
        public virtual DbSet<profesion> profesion { get; set; }
        public virtual DbSet<rango> rango { get; set; }
        public virtual DbSet<soldado> soldado { get; set; }
        public virtual DbSet<soldadoTipoArma> soldadoTipoArma { get; set; }
        public virtual DbSet<tipoArma> tipoArma { get; set; }
        public virtual DbSet<tipoUsuario> tipoUsuario { get; set; }
        public virtual DbSet<tipoVehiculo> tipoVehiculo { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<vehiculo> vehiculo { get; set; }
    }
}