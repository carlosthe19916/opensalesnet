using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.beans.representations
{
    [DataContract]
    public class VentaRepresentation
    {
        [DataMember]
        public String id { get; set; }

        [DataMember]
        public DateTime fecha { get; set; }
       
    }
}
