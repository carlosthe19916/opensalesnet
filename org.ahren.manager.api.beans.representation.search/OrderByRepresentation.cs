using System;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representation.search
{
    [DataContract]
    public class OrderByRepresentation
    {
       
        [DataMember]
        public bool ascending { get; set; }

        [DataMember]
        public String name { get; set; }

        public OrderByRepresentation()
        {   
                     
        }        

    }

}