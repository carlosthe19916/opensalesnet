using System;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representations
{
    [DataContract]
    public class BovedaRepresentation
    {
        [DataMember]
        public String id { get; set; }

        [DataMember]
        public String denominacion { get; set; }

        [DataMember]
        public String abierto { get; set; }

        [DataMember]
        public OficinaRepresentation oficina { get; set; }

        public BovedaRepresentation()
        {

        }
    }
}
