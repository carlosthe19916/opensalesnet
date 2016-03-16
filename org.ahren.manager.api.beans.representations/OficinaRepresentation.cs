using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representations
{
    [DataContract]
    public class OficinaRepresentation    
    {
        [DataMember]
        public String id { get; set; }

        [DataMember]
        public String denomination { get; set; }

        [DataMember]
        public String ubigeo { get; set; }

        public OficinaRepresentation ()
        {

        }
    }
}
