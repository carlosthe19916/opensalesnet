using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representation.search
{
	[DataContract]
    public class SearchCriteriaRepresentation
    {
		[DataMember]
        public String filterText { get; set; }

        [DataMember]
        public IList<SearchCriteriaFilterRepresentation> filters { get; set; }

        [DataMember]
        public IList<OrderByRepresentation> orders { get; set; }

        [DataMember]
        public PagingRepresentation paging { get; set; }

        public SearchCriteriaRepresentation()
        {
            filters = new List<SearchCriteriaFilterRepresentation>();
            orders = new List<OrderByRepresentation>();
            paging = new PagingRepresentation();
        }      

    }

}