using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    public class OficinaEntity
    {
        public String id { get; set; }

        public String denominacion { get; set; }

        public String ubigeo { get; set; }
    }
}
