using System;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representations.info
{
    [DataContract]
    public class ServerInfoRepresentation
    {
        public String version { get; set; }
    }

}