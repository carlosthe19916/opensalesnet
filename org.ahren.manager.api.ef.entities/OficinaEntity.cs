using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef.entities
{
    [Table("OFICINA")]
    public class OficinaEntity
    {
        [Key]
        public String id { get; set; }

        [Column("denominacion")]
        [MaxLength(200)]
        public String denominacion { get; set; }

        public String ubigeo { get; set; }

        /*[ForeignKey("StdId")]
        public virtual Standard Standard { get; set; }*/
    }
}
