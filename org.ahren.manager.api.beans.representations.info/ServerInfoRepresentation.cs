using System;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representations.info
{
    [DataContract]
    public class ServerInfoRepresentation
    {
        [DataMember]
        public String version { get; set; }
    }

}