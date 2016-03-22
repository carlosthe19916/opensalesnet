using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    [Table("VENTA")]
    public class VentaEntity
    {
        public String id { get; set; }

        public DateTime fecha { get; set; }
       
    }
}
