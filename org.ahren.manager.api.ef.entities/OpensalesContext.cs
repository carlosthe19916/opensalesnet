using System;
using System.Data.Entity;

namespace org.ahren.manager.api.ef.entities
{
    public class OpensalesContext : DbContext
    {
        public OpensalesContext() : base("opensales")
        {
            Database.SetInitializer<OpensalesContext>(new CreateDatabaseIfNotExists<OpensalesContext>());
        }

        public DbSet<OficinaEntity> OficinasEntity { get; set; }

        public DbSet<BovedaEntity> BovedaEntity { get; set; }

        public DbSet<HistorialBovedaEntity> HistorialBovedaEntity { get; set; }

        public DbSet<CajaEntity> CajaEntity { get; set; }

        public DbSet<HistorialCajaEntity> HistorialCajaEntity { get; set; }

        public DbSet<VentaEntity> VentaEntity { get; set; }

        public DbSet<DetalleVentaEntity> DetalleVentaEntity { get; set; }
    }
}
