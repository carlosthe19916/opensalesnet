using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.beans.representations
{
    [DataContract]
    public class DetalleVentaRepresentation
    {
        [DataMember]
        public String id { get; set; }

        [DataMember]
        public String codigo { get; set; }

        [DataMember]
        public String denominacion { get; set; }

        [DataMember]
        public int cantidad { get; set; }

        [DataMember]
        public double precioUnitario { get; set; }

        [DataMember]
        public double subtotal { get; set; }

        [DataMember]
        public VentaRepresentation venta { get; set; }
    }
}
