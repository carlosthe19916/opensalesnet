using System;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representation.search
{
    [DataContract]
    public class PagingRepresentation
    {
       
        [DataMember]
        public int page { get; set; }

        [DataMember]
        public int pageSize { get; set; }

        public PagingRepresentation()
        {

        }

    }
}