using System;
using System.Data.Entity;

namespace org.ahren.manager.api.ef.entities
{
    public class Context : DbContext
    {
        public Context() : base("Opensales")
        {

        }

        DbSet<OficinaEntity> oficinaEntity { get; set; }

        DbSet<BovedaEntity> bovedaEntity { get; set; }

        DbSet<HistorialBovedaEntity> historialBovedaEntity { get; set; }

        DbSet<CajaEntity> cajaEntity { get; set; }

        DbSet<HistorialCajaEntity> historialCajaEntity { get; set; }

        DbSet<VentaEntity> ventaEntity { get; set; }

        DbSet<DetalleVentaEntity> detalleVentaEntity { get; set; }
    }
}
