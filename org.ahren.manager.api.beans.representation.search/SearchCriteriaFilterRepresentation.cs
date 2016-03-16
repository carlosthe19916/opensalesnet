using System;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representation.search
{
	[DataContract]
    public class SearchCriteriaFilterRepresentation
    {
		[DataMember]
        public String name { get; set; }

        [DataMember]
        public Object value { get; set; }

        [DataMember]
        public SearchCriteriaFilterOperatorRepresentation op { get; set; }

        public SearchCriteriaFilterRepresentation()
        {            

        }

    }

}