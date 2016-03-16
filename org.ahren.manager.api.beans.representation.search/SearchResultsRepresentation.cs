using System.Collections.Generic;
using System.Runtime.Serialization;

namespace org.ahren.manager.api.beans.representation.search
{
	[DataContract]
    public class SearchResultsRepresentation<T>
    {
        
		[DataMember]
        public IList<T> items { get; set; }

        [DataMember]
        public int totalSize { get; set; }
	
        public SearchResultsRepresentation()
        {
            items = new List<T>();
        }

    }
}
