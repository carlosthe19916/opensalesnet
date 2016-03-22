using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.beans.representations
{
    [DataContract]
    public class HistorialBovedaRepresentation
    {
        [DataMember]
        public String id { get; set; }

        [DataMember]
        public DateTime fechaApertura { get; set; }

        [DataMember]
        public DateTime fechaCierre { get; set; }

        [DataMember]
        public bool estado { get; set; }

        [DataMember]
        public BovedaRepresentation boveda { get; set; }

    }
}
