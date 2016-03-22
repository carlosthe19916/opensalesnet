using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.beans.representations
{
    [DataContract]
    public class CajaRepresentation
    {
        [DataMember]
        public String id { get; set; }

        [DataMember]
        public String denominacion { get; set; }

        [DataMember]
        public String abierto { get; set; }
         
    }
}
