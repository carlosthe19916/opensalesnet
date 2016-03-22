using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    public class DetalleVentaEntity
    {
        public String id { get; set; }

        public String codigo { get; set; }

        public String denominacion { get; set; }

        public int cantidad { get; set; }

        [Column("precio_unitario")]
        public double precioUnitario { get; set; }

        public double subtotal { get; set; }

        [Required]
        public virtual VentaEntity venta { get; set; }
    }
}
